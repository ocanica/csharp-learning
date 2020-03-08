using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Stratergy
{
    public class Electric : IAdvisoryFuelRate
    {
        public float PencePerMile { get; private set; }

        //public EngineSize engineSize { get; private set; }

        public string EngineType { get; private set; }

        public Electric()
        {
            EngineType = "Electric";
            PencePerMile = 0.040f;
        }

        public void ChangeEngineSize(EngineSize engineSize)
            => Console.WriteLine("EMV has only 1 engine size");
    }
}
