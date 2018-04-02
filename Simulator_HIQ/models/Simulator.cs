using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.Actions;
namespace Simulator_HIQ.models
{
    class Simulator
    {
        Room mRoom;
        Vehicle mVehicle;
        List<IAction> mActions;
        bool mSimulationFailed = false;
        bool mInitialized = false;
        List<BangToTheWall> errorList = new List<BangToTheWall>();
        public bool Initialize(Vehicle rcVehicle)
        {
            Point parsedPoint;
            Console.WriteLine("Enter room size (ex: 8 12): ");
            if (!InputHelper.ParseInputTo(out parsedPoint))
            {
                Console.WriteLine("Error room size.");
                return false;
            }
            mRoom = new Room(parsedPoint);

            mVehicle = rcVehicle;
            Riktning parsedDirection;
            Console.WriteLine("Enter location and direction (ex: 3 6 E): ");
            if (!InputHelper.ParseInputTo(out parsedPoint, out parsedDirection))
            {
                Console.WriteLine("Error location or direction.");
                return false;
            }
            mVehicle.Location = parsedPoint;
            mVehicle.CurrentDirection = parsedDirection;

            Console.WriteLine("Enter a sequence of actions (ex: RRLLFFBB). ");
            mActions = InputHelper.ParseActions();
            if (mActions == null)
            {
                Console.WriteLine("Error adding actions.");
                return false;
            }

            mInitialized = true;
            return true;
        }

        public bool Run()
        {
            if (!mInitialized)
            {
                Console.WriteLine("Not initialized.");
                return false;
            }

            mSimulationFailed = false;
            for (int i = 0; i < mActions.Count; i++)
            {
                mActions[i].Execute(mVehicle);

                if (checkCollisionBetween(mRoom, mVehicle))
                {
                    mSimulationFailed = true;
                    BangToTheWall b = new BangToTheWall();
                    b.Index = i;
                    b.Command = mVehicle.Location.X.ToString() + ", " + mVehicle.Location.Y.ToString();
                    errorList.Add(b);
                }
            }

            return !mSimulationFailed;
        }
   
        private bool checkCollisionBetween(Room room, Vehicle vehicle)
        {
            return vehicle.Location.X > room.Width ||
                vehicle.Location.X < 0 ||
                vehicle.Location.Y > room.Height ||
                vehicle.Location.Y < 0;
        }
  
        public void PrintResults()
        {
            if (!mInitialized)
            {
                Console.WriteLine("Not initialized.");
                return;
            }

            if (mSimulationFailed)
            {
                Console.WriteLine("Oops you drove in to the wall, here: ");
                foreach (var e in errorList)
                {
                    Console.WriteLine("Command no: " + e.Index + " position: " + e.Command);
                }               
            }
            else
            {
                Console.WriteLine("Nice done!");
            }
        }
    }
}
