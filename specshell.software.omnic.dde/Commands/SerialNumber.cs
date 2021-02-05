namespace Specshell.Omnic.Dde.Commands
{
    public class SerialNumber : IDdeRequestCommand<string>
    {
        private SerialNumber(string parameter)
        {
            Command = $"SerialNumber {parameter}";
        }

        public string Command { get; }

        public static SerialNumber GetBench() => new("Spectrometer");
        public static SerialNumber GetInfraredSource() => new("IRSource");
    }
}
