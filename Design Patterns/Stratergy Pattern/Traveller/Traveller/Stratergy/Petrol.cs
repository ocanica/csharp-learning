using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Stratergy
{
    public class Petrol : IAdvisoryFuelRate
    {
        public float PencePerMile { get; private set; }

        public EngineSize engineSize { get; private set; }

        public string EngineType { get; private set; }

        public Petrol(EngineSize engineSize = EngineSize.Small)
        {
            EngineType = "Petrol";
            ChangeEngineSize(engineSize);
        }

        public void ChangeEngineSize(EngineSize engineSize)
        {
            switch (engineSize)
            {
                case EngineSize.Medium:
                    PencePerMile = 0.139f;
                    this.engineSize = engineSize;
                    break;
                case EngineSize.Large:
                    PencePerMile = 0.203f;
                    this.engineSize = engineSize;
                    break;
                default:
                    PencePerMile = 0.116f;
                    this.engineSize = engineSize;
                    break;
            }
        }
    }
}
