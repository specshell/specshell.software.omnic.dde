namespace Specshell.Omnic.Dde.Commands
{
    public class Spectrum : IDdeCommand
    {
        private readonly string _parameter;
        private Spectrum(string parameter)
        {
            _parameter = parameter;
        }

        public static Spectrum FirstX() => new("FirstX");
        public static Spectrum LastX() => new("LastX");
        public static Spectrum Noise() => new("Noise");
        public static Spectrum PeakHeight() => new("PeakHeight");
        public static Spectrum XAxisId() => new Spectrum("XAxisID");

        /// <summary>
        /// Command to Retrieve or Set Spectrum Title.
        /// </summary>
        /// <param name="title">Leave empty to retrieve title or set to a non empty value will make the command set the spectrum title</param>
        /// <returns>Spectrum Title Command</returns>
        public static Spectrum Title(string title = "")
        {
            var spectrum = new Spectrum("Title");
            if (string.IsNullOrWhiteSpace(title)) return spectrum;
            spectrum.Data = title;
            spectrum.Type = CommandType.Poke;
            return spectrum;
        }

        public string Command => $"Spectrum ${_parameter}";
        public string Data { get; private set; } = string.Empty;

        public CommandType Type { get; private set; } = CommandType.Request;
    }
}