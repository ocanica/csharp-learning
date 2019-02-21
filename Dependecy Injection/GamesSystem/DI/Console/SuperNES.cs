using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Games;

namespace DI.Console
{
    class SuperNES : IGamesConsole
    {
        private readonly IGames _game;

        // All SuperNES consoles ship with Zelda Link to the Past
        public SuperNES()
            :this(new ZeldaLinkToThePast())
        {

        }

        public SuperNES(IGames game)
        {
            _game = game;
        }

        public void LoadGames()
        {
            _game.PressStart();
            _game.PlayGame();
        }
    }
}
