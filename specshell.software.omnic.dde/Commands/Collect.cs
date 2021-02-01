using System.Globalization;

namespace Specshell.Omnic.Dde.Commands
{
    public class Collect : IDdeCommand
    {
        private readonly string _parameter;

        private Collect(string parameter)
        {
            _parameter = parameter;
            Data = string.Empty;
        }

        private Collect(string parameter, string data)
        {
            _parameter = parameter;
            Data = data;
            Type = CommandType.Poke;
        }

        internal static Collect FinalFormat(string format = "") => string.IsNullOrWhiteSpace(format)
            ? new Collect("FinalFormat")
            : new Collect("FinalFormat", format);

        internal static Collect FinalFormatInterferogram() => FinalFormat("Interferogram");
        internal static Collect FinalFormatAbsorbance() => FinalFormat("Absorbance");
        internal static Collect FinalFormatSingleBeam() => FinalFormat("SingleBeam");

        internal static Collect BackgroundFileName(string fileName = "") => string.IsNullOrWhiteSpace(fileName)
            ? new Collect("BackgroundFileName")
            : new Collect("BackgroundFileName", fileName);

        internal static Collect NumberOfScans() => new("NumScans");
        internal static Collect NumberOfScans(int number) => new("NumScans", number.ToString(CultureInfo.InvariantCulture));

        internal static Collect SaveInterferograms() => new("SaveInterferograms");
        internal static Collect SaveInterferograms(bool save) => new("SaveInterferograms", save ? "TRUE" : "FALSE");

        internal static Collect AtmosphericSuppression(bool suppress) =>
            new("Collect DataCorrections", suppress ? "Atmospheric suppression" : "None");

        public string Command => $"Collect {_parameter}";
        public string Data { get; }
        public CommandType Type { get; } = CommandType.Request;
    }
}