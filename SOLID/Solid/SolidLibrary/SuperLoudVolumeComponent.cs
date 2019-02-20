using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLibrary
{
    public class SuperLoudVolumeComponent : VolumeComponent
    {
        public override void VolumeUp()
        {
            base.VolumeUp();

            if(true)
            {
                // Volume goes to 11
            }
        }
    }
}
