using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.GameMechanics
{
    public class HumanPlayer : IPlayer
    {
        private readonly ConsoleKeyInfo _info = System.Console.ReadKey();

        public void MoveDirection()
        {
            switch (_info.Key)
            {
                case ConsoleKey.UpArrow:
                    System.Console.WriteLine($"Player moves { Direction.Up }");
                    break;
                case ConsoleKey.DownArrow:
                    System.Console.WriteLine($"Player moves { Direction.Down }");
                    break;
                case ConsoleKey.LeftArrow:
                    System.Console.WriteLine($"Player moves { Direction.Left }");
                    break;
                case ConsoleKey.RightArrow:
                    System.Console.WriteLine($"Player moves { Direction.Right }");
                    break;
                default:
                    System.Console.WriteLine($"Player immobile");
                    break;
            }
        }

        public void PlayerAction()
        {
            switch (_info.Key)
            {
                case ConsoleKey.Spacebar:
                    System.Console.WriteLine($"Player { Action.Jump }");
                    break;
                default:
                    System.Console.WriteLine("No action taken");
                    break;
            }
        }
    }
}
