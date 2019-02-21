using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.GameItems.Weapons
{
    class Hammer : IWeapon
    {
        public void Attack()
        {
            System.Console.WriteLine("You swing your hammer");
        }
    }
}
