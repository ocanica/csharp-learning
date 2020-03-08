using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Stratergy
{
    public class LPG : IAdvisoryFuelRate
    {
        public float PencePerMile { get; private set; }

        public EngineSize engineSize { get; private set; }

        public string EngineType { get; private set; }

        public LPG(EngineSize engineSize = EngineSize.Small)
        {
            EngineType = "LPG";
            ChangeEngineSize(engineSize);
        }

        public void ChangeEngineSize(EngineSize engineSize)
        {
            switch (engineSize)
            {
                case EngineSize.Medium:
                    PencePerMile = 0.096f;
                    this.engineSize = engineSize;
                    break;
                case EngineSize.Large:
                    PencePerMile = 0.140f;
                    this.engineSize = engineSize;
                    break;
                default:
                    PencePerMile = 0.080f;
                    this.engineSize = engineSize;
                    break;
            }
        }
    }
}
