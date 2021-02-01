namespace Specshell.Omnic.Dde.Commands
{
    public class SerialNumber : IDdeCommand
    {
        private readonly string _parameter;

        private SerialNumber(string parameter)
        {
            _parameter = parameter;
        }

        internal static SerialNumber Spectrometer() => new("Spectrometer");
        internal static SerialNumber IrSource() => new("IRSource");

        public string Command => $"SerialNumber {_parameter}";
        public string Data => string.Empty;
        public CommandType Type => CommandType.Request;
    }
}