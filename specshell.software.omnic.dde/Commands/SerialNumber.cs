namespace Specshell.Omnic.Dde.Commands
{
    public class SerialNumber : IDdeRequestCommand<string>
    {
        private readonly string _parameter;

        private SerialNumber(string parameter)
        {
            _parameter = parameter;
        }

        public static SerialNumber GetBench() => new("Spectrometer");
        public static SerialNumber GetInfraredSource() => new("IRSource");

        public string Command => $"SerialNumber {_parameter}";
    }
}