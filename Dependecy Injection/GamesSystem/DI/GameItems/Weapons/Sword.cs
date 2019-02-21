using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.GameItems.Weapons
{
    class Sword : IWeapon
    {
        public void Attack()
        {
            System.Console.WriteLine("You slash your sword");
        }
    }
}
