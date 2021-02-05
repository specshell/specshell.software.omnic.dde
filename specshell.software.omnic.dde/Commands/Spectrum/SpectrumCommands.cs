namespace Specshell.Omnic.Dde.Commands.Spectrum
{
    public static class SpectrumCommands
    {
        public static SpectrumCommandRequest<string> GetFirstX() => new("FirstX");
        public static SpectrumCommandRequest<string> GetLastX() => new("LastX");
        public static SpectrumCommandRequest<double> GetNoise() => new("Noise");
        public static SpectrumCommandRequest<double> GetPeakHeight() => new("PeakHeight");
        public static SpectrumCommandRequest<string> GetXAxisId() => new("XAxisID");
        public static SpectrumCommandRequest<string> GetYAxisId() => new("YAxisID");
        public static SpectrumCommandRequest<long> GetCollectTime() => new("CollectTime");
        public static SpectrumCommandRequest<string> GetDuration() => new("Duration");
        public static SpectrumCommandRequest<double> GetGain() => new("Gain");
        public static SpectrumCommandRequest<double> GetLaserFrequency() => new("LaserFreq");
        public static SpectrumCommandRequest<double> GetMirrorVelocity() => new("Velocity");
        public static SpectrumCommandRequest<int> GetNumberOfScans() => new("NumScans");
        public static SpectrumCommandRequest<string> GetTitle() => new("Title");
        public static SpectrumCommandPoke SetTitle(string title = "") => new("Title", title);
    }
}
