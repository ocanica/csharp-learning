using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidLibrary;

namespace Solid
{
    class Program
    {

        static void Main(string[] args)
        {
            var GuitarAmp = new GuitarAmp(
                new SuperLoudVolumeComponent(),
                new SpecialEffectsComponent(), 
                new AwesomeHeadphoneComponent(),
                new FootSwitchComponent()
            );

            GuitarAmp.PlayAwesome();
        }
    }
}
