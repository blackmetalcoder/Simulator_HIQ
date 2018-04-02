using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator_HIQ.Actions;
using Simulator_HIQ.models;
namespace Simulator_HIQ.models
{
    class InputHelper
    {
        public static bool ParseInputTo(out Point location)
        {
            Riktning temp;
            return ParseInputTo(out location, out temp);
        }
        public static bool ParseInputTo(out Point location, out Riktning direction)
        {
            string[] inputs;
            location = null;
            direction = Riktning.INVALID;

            while (true)
            {
                inputs = Console.ReadLine().ToUpper().Split(' ');

                if (inputs.Length >= 2)
                {
                    location = Point.ParseFromStrings(inputs[0], inputs[1]);
                    if (location == null)
                    {
                        Console.WriteLine("Error parsing to integer. ");
                        continue;
                    }
                }
                else
                {
                    continue;
                }

                if (inputs.Length >= 3)
                {
                    if (!char.IsLetter(inputs[2][0]))
                    {
                        Console.WriteLine("Third parameter is not a letter.");
                        continue;
                    }
                    if (!Enum.TryParse(inputs[2], out direction))
                    {
                        Console.WriteLine("Error while parsing. ");
                        continue;
                    }
                    return true;
                }
                else
                {
                    if (location != null) return true;
                    return false;
                }
            }
        }
        public static List<IAction> ParseActions()
        {
            string inputs;
            inputs = Console.ReadLine().ToUpper();

            if (inputs.Length == 0)
            {
                return null;
            }

            List<IAction> listTemp = new List<IAction>();
            foreach (char c in inputs)
            {
                switch (c)
                {
                    case 'F':
                        listTemp.Add(new MoveForwardsAction());
                        break;
                    case 'B':
                        listTemp.Add(new MoveBackwardsAction());
                        break;
                    case 'L':
                        listTemp.Add(new TurnLeftAction());
                        break;
                    case 'R':
                        listTemp.Add(new TurnRightAction());
                        break;
                    default:
                        break;
                }
            }

            return listTemp;
        }
    }
}
