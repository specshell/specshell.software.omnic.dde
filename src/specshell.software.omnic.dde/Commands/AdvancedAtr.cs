namespace Specshell.Omnic.Dde.Commands
{
    public class AdvancedAtr : IDdeExecuteCommand
    {
        public AdvancedAtr(
            float sampleRefractiveIndex = 1.36f,
            float crystalRefractiveIndex = 2.40f,
            float numberOfBounces = 1.0f,
            float angleOfIncidence = 45.0f)
        {
            Command = $"[AdvancedATR {sampleRefractiveIndex} {crystalRefractiveIndex} {numberOfBounces} {angleOfIncidence}]";
        }

        public string Command { get; }
    }
}
