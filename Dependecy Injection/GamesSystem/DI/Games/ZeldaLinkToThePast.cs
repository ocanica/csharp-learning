using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.GameItems;
using DI.GameItems.Weapons;

namespace DI.Games
{
    public class ZeldaLinkToThePast : IGames
    {
        private readonly IWeapon _weapon;

        public ZeldaLinkToThePast()
            :this(new Sword())
        {

        }
        public ZeldaLinkToThePast(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void PressStart()
        {
            System.Console.WriteLine("Loading Zelda...");
        }

        public void PlayGame()
        {
            _weapon.Attack();

            System.Console.WriteLine("Killing Gannon!");
        }
    }
}
