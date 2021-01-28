namespace Specshell.Omnic.Dde.Commands
{
    public class AdvancedAtr : ICommand
    {
        private readonly double _crystalRefractiveIndex;
        private readonly double _angleOfIncidenceDegrees;
        private readonly double _numberOfBounces;
        private readonly double _sampleRefractiveIndex;

        public AdvancedAtr(double crystalRefractiveIndex, double angleOfIncidenceDegrees, double numberOfBounces, double sampleRefractiveIndex)
        {
            _crystalRefractiveIndex = crystalRefractiveIndex;
            _angleOfIncidenceDegrees = angleOfIncidenceDegrees;
            _numberOfBounces = numberOfBounces;
            _sampleRefractiveIndex = sampleRefractiveIndex;
        }

        public string Command => $"[AdvancedATR {_crystalRefractiveIndex} {_angleOfIncidenceDegrees} {_numberOfBounces} {_sampleRefractiveIndex}]";

        public CommandType Type => CommandType.Execute;
    }
}