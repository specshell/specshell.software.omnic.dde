namespace Specshell.Omnic.Dde.Commands.Spectrum
{
    public class SpectrumCommand : IDdeCommand
    {
        public SpectrumCommand(string parameter)
        {
            Command = $"Spectrum {parameter}";
        }

        public string Command { get; }
    }
}