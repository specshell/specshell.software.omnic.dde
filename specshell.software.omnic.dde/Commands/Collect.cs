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

        public static Collect FinalFormat(string format = "") => string.IsNullOrWhiteSpace(format)
            ? new Collect("FinalFormat")
            : new Collect("FinalFormat", format);

        public static Collect BackgroundFileName(string fileName = "") => string.IsNullOrWhiteSpace(fileName)
            ? new Collect("BackgroundFileName")
            : new Collect("BackgroundFileName", fileName);

        public static Collect NumberOfScans() => new("NumScans");
        public static Collect NumberOfScans(int number) => new("NumScans", number.ToString(CultureInfo.InvariantCulture));

        public static Collect SaveInterferograms() => new("SaveInterferograms");
        public static Collect SaveInterferograms(bool save) => new("SaveInterferograms", save ? "TRUE" : "FALSE");

        public static Collect AtmosphericSuppression(bool suppress) =>
            new("Collect DataCorrections", suppress ? "Atmospheric suppression" : "None");

        public string Command => $"Collect {_parameter}";
        public string Data { get; }
        public CommandType Type { get; } = CommandType.Request;
    }
}