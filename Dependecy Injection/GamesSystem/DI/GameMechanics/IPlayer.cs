using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.GameMechanics
{
    public enum Direction { None, Up, Down, Left, Right };
    public enum Action { None, Jump };

    public interface IPlayer
    {
        void MoveDirection();
        void PlayerAction();
    }
}
