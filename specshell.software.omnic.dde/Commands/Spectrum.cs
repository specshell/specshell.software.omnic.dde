namespace Specshell.Omnic.Dde.Commands
{
    public class Spectrum : IDdeCommand
    {
        private readonly string _parameter;

        private Spectrum(string parameter)
        {
            _parameter = parameter;
        }

        private Spectrum(string parameter, string title)
        {
            _parameter = parameter;
            Data = title;
            Type = CommandType.Poke;
        }

        internal static Spectrum FirstX() => new("FirstX");
        internal static Spectrum LastX() => new("LastX");
        internal static Spectrum Noise() => new("Noise");
        internal static Spectrum PeakHeight() => new("PeakHeight");
        internal static Spectrum XAxisId() => new("XAxisID");
        internal static Spectrum YAxisId() => new("YAxisID");
        internal static Spectrum CollectTime() => new("CollectTime");
        internal static Spectrum Duration() => new("Duration");
        internal static Spectrum Gain() => new("Gain");
        internal static Spectrum LaserFrequency() => new("LaserFreq");
        internal static Spectrum MirrorVelocity() => new("Velocity");
        internal static Spectrum NumberOfScans() => new("NumScans");

        /// <summary>
        /// Command to Retrieve or Set Spectrum Title.
        /// </summary>
        /// <param name="title">Leave empty to retrieve title or set to a non empty value will make the command set the spectrum title</param>
        /// <returns>Spectrum Title Command</returns>
        internal static Spectrum Title(string title = "") => string.IsNullOrWhiteSpace(title)
            ? new Spectrum("Title")
            : new Spectrum("Title", title);

        public string Command => $"Spectrum {_parameter}";
        public string Data { get; } = string.Empty;

        public CommandType Type { get; } = CommandType.Request;
    }
}