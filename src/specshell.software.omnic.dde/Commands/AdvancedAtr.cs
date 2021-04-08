namespace Specshell.Omnic.Dde.Commands
{
    public class AdvancedAtr : IDdeExecuteCommand
    {
        public AdvancedAtr(
            double crystalRefractiveIndex = 1.36,
            double angleOfIncidenceDegrees = 2.40,
            double numberOfBounces = 1.0,
            double sampleRefractiveIndex = 45.0)
        {
            Command = $"[AdvancedATR {crystalRefractiveIndex} {angleOfIncidenceDegrees} {numberOfBounces} {sampleRefractiveIndex}]";
        }

        public string Command { get; }
    }
}
