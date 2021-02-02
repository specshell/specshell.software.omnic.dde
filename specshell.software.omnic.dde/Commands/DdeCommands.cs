namespace Specshell.Omnic.Dde.Commands
{
    public static class DdeCommands
    {
        public static About About() => new();

        public static AdvancedAtr AdvancedAtr(
            double crystalRefractiveIndex = 1.36,
            double angleOfIncidenceDegrees = 2.40,
            double numberOfBounces = 1.0,
            double sampleRefractiveIndex = 45.0)
            => new(crystalRefractiveIndex, angleOfIncidenceDegrees, numberOfBounces, sampleRefractiveIndex);

        public static AutoTune AutoTune() => new();
        public static BenchStatus BenchStatusBoardTemperature() => BenchStatus.BoardTemperature();
        public static BenchStatus BenchStatusModulatorTemperature() => BenchStatus.ModulatorTemperature();
        public static BenchStatus BenchStatusHumidity() => BenchStatus.Humidity();
        public static BenchStatus BenchStatusLaserMilliampere() => BenchStatus.LaserMilliampere();
        public static BenchStatus BenchStatusLaserTemperature() => BenchStatus.LaserTemperature();
        public static BenchStatus BenchStatusLaserR() => BenchStatus.LaserR();
        public static BenchStatus BenchStatusLaserX() => BenchStatus.LaserX();
        public static BenchStatus BenchStatusLaserY() => BenchStatus.LaserY();
        public static BenchStatus BenchStatusInfraredSourceAmpere() => BenchStatus.InfraredSourceAmpere();
        public static BenchStatus BenchStatusInfraredSourceVolt() => BenchStatus.InfraredSourceVolt();
        public static Collect ColectBackgroundFileName(string fileName = "") => Collect.BackgroundFileName(fileName);
        public static Collect CollectFinalFormat(string format = "") => Collect.FinalFormat(format);
        public static Collect CollectFinalFormatInterferogram() => Collect.FinalFormatInterferogram();
        public static Collect CollectFinalFormatAbsorbance() => Collect.FinalFormatAbsorbance();
        public static Collect CollectFinalFormatSingleBeam() => Collect.FinalFormatSingleBeam();
        public static Collect CollectSaveInterferograms() => Collect.SaveInterferograms();
        public static Collect CollectSaveInterferograms(bool save) => Collect.SaveInterferograms(save);
        public static Collect CollectNumberOfScans() => Collect.NumberOfScans();
        public static Collect CollectNumberOfScans(int number) => Collect.NumberOfScans(number);
        public static Collect CollectAtmosphericSuppression(bool suppress) => Collect.AtmosphericSuppression(suppress);
        public static CollectSample CollectSample(string sampleTitle = "") => new(sampleTitle);
        public static Export Export(string path = "") => new(path);
        public static DeleteSelectedSpectra DeleteSelectedSpectra() => new();
        public static Display Display(string select = "") => new(select);
        public static Multiply Multiply(double factor) => new(factor);
        public static ResultCurrent ResultCurrent() => new();
        public static Reprocess Reprocess() => new();
        public static Select Select(string select = "") => new(select);
        public static Select SelectAll() => Commands.Select.All();
        public static Spectrum SpectrumFirstX() => Spectrum.FirstX();
        public static Spectrum SpectrumLastX() => Spectrum.LastX();
        public static Spectrum SpectrumNoise() => Spectrum.Noise();
        public static Spectrum SpectrumPeakHeight() => Spectrum.PeakHeight();
        public static Spectrum SpectrumTitle(string title = "") => Spectrum.Title(title);
        public static Spectrum SpectrumXAxisId() => Spectrum.XAxisId();
        public static Spectrum SpectrumYAxisId() => Spectrum.YAxisId();
        public static Spectrum SpectrumCollectTime() => Spectrum.CollectTime();
        public static Spectrum SpectrumDuration() => Spectrum.Duration();
        public static Spectrum SpectrumGain() => Spectrum.Gain();
        public static Spectrum SpectrumLaserFrequency() => Spectrum.LaserFrequency();
        public static Spectrum SpectrumMirrorVelocity() => Spectrum.MirrorVelocity();
        public static Spectrum SpectrumNumberOfScan() => Spectrum.NumberOfScans();
        public static Parameters SaveParameters(string path) => Parameters.SaveParameters(path);
        public static Parameters LoadParameters(string path) => Parameters.LoadParameters(path);
        public static SerialNumber BenchSerialNumber() => SerialNumber.Bench();
        public static SerialNumber InfraredSourceSerialNumber() => SerialNumber.InfraredSource();
    }
}