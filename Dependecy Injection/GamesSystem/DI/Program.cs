using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Console;
using DI.Games;
using DI.GameItems.Weapons;
using DI.GameMechanics;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesConsole = new SuperNES(new SuperMarioWorld(new HumanPlayer()));

            gamesConsole.LoadGames();

            System.Console.ReadLine();
        }
    }
}
