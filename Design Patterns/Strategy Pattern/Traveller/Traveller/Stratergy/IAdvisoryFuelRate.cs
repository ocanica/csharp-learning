namespace Traveller.Stratergy
{
    public enum EngineSize
    {
        Small,
        Medium,
        Large
    }

    public interface IAdvisoryFuelRate
    {
        float PencePerMile { get; }
        string EngineType { get; }
        EngineSize engineSize { get; }

        void ChangeEngineSize(EngineSize engineSize);
    }
}
