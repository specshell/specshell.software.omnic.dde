namespace Specshell.Omnic.Dde.Commands.Spectrum;

public class SpectrumCommandPoke : SpectrumCommand, IDdePokeCommand
{
    public SpectrumCommandPoke(string parameter, string data) : base(parameter)
    {
        Data = data;
    }

    public string Data { get; }
}