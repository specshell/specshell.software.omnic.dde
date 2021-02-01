namespace Specshell.Omnic.Dde.Commands
{
    public class AdvancedAtr : IDdeCommand
    {
        private readonly double _crystalRefractiveIndex;
        private readonly double _angleOfIncidenceDegrees;
        private readonly double _numberOfBounces;
        private readonly double _sampleRefractiveIndex;

        internal AdvancedAtr(double crystalRefractiveIndex = 1.36, double angleOfIncidenceDegrees = 2.40, double numberOfBounces = 1.0,
            double sampleRefractiveIndex = 45.0)
        {
            _crystalRefractiveIndex = crystalRefractiveIndex;
            _angleOfIncidenceDegrees = angleOfIncidenceDegrees;
            _numberOfBounces = numberOfBounces;
            _sampleRefractiveIndex = sampleRefractiveIndex;
        }

        public string Command =>
            $"[AdvancedATR {_crystalRefractiveIndex} {_angleOfIncidenceDegrees} {_numberOfBounces} {_sampleRefractiveIndex}]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}