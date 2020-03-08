namespace Traveller.Stratergy
{
    public class Diesel : IAdvisoryFuelRate
    {
        public float PencePerMile { get; private set; }
        public EngineSize engineSize { get; private set; }
        public string EngineType { get; private set; }

        public Diesel(EngineSize engineSize = EngineSize.Small)
        {
            EngineType = "Diesel";
            ChangeEngineSize(engineSize);
        }

        public void ChangeEngineSize(EngineSize engineSize)
        {
            switch (engineSize)
            {
                case EngineSize.Medium:
                    PencePerMile = 0.108f;
                    this.engineSize = engineSize;
                    break;
                case EngineSize.Large:
                    PencePerMile = 0.134f;
                    this.engineSize = engineSize;
                    break;
                default:
                    PencePerMile = 0.093f;
                    this.engineSize = engineSize;
                    break;
            }
        }
    }
}
