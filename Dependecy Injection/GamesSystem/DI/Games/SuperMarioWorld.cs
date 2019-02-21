using DI.GameMechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Games
{
    class SuperMarioWorld : IGames
    {
        private readonly IPlayer _player;

        public SuperMarioWorld(IPlayer player)
        {
            _player = player;
        }

        public void PressStart()
        {
            System.Console.WriteLine("Loading Super Mario World...");
        }

        public void PlayGame()
        {
            _player.MoveDirection();
            _player.PlayerAction();
            System.Console.WriteLine("Defeating Bowser!");
        }
    }
}
