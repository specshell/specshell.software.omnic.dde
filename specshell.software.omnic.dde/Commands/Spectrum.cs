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

        public static Spectrum FirstX() => new("FirstX");
        public static Spectrum LastX() => new("LastX");
        public static Spectrum Noise() => new("Noise");
        public static Spectrum PeakHeight() => new("PeakHeight");
        public static Spectrum XAxisId() => new ("XAxisID");
        public static Spectrum YAxisId() => new ("YAxisID");

        /// <summary>
        /// Command to Retrieve or Set Spectrum Title.
        /// </summary>
        /// <param name="title">Leave empty to retrieve title or set to a non empty value will make the command set the spectrum title</param>
        /// <returns>Spectrum Title Command</returns>
        public static Spectrum Title(string title = "") => string.IsNullOrWhiteSpace(title)
            ? new Spectrum("Title")
            : new Spectrum("Title", title);

        public string Command => $"Spectrum {_parameter}";
        public string Data { get; } = string.Empty;

        public CommandType Type { get; } = CommandType.Request;
    }
}