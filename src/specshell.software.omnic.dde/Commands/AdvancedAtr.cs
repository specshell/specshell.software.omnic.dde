namespace Specshell.Omnic.Dde.Commands
{
    public class AdvancedAtr : IDdeExecuteCommand
    {
        public AdvancedAtr(
            double sampleRefractiveIndex = 1.36,
            double crystalRefractiveIndex = 2.40,
            double numberOfBounces = 1.0,
            double angleOfIncidence = 45.0)
        {
            Command = $"[AdvancedATR {sampleRefractiveIndex} {crystalRefractiveIndex} {numberOfBounces} {angleOfIncidence}]";
        }

        public string Command { get; }
    }
}
