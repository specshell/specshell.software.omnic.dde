namespace Specshell.Omnic.Dde.Commands
{
    public static class DdeCommands
    {
        public static About About => new();

        public static AdvancedAtr AdvancedAtr(
            double crystalRefractiveIndex = 1.36,
            double angleOfIncidenceDegrees = 2.40,
            double numberOfBounces = 1.0,
            double sampleRefractiveIndex = 45.0)
            => new(crystalRefractiveIndex, angleOfIncidenceDegrees, numberOfBounces, sampleRefractiveIndex);

        public static CollectSample CollectSample(string sampleTitle = "") => new(sampleTitle);
        public static Export Export(string path = "") => new (path);
        public static Display Display(string select = "") => new(select);
        public static Multiply Multiply(double factor) => new (factor);
        public static Select Select(string select = "") => new(select);
        public static Select SelectAll => Commands.Select.All();
        public static Spectrum SpectrumFirstX => Spectrum.FirstX();
        public static Spectrum SpectrumLastX => Spectrum.LastX();
        public static Spectrum SpectrumNoise => Spectrum.Noise();
        public static Spectrum SpectrumPeakHeight => Spectrum.PeakHeight();
        public static Spectrum SpectrumTitle(string title = "") => Spectrum.Title(title);
        public static Spectrum SpectrumXAxisId => Spectrum.XAxisId();
    }
}