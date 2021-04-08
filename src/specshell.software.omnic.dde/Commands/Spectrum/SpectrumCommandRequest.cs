namespace Specshell.Omnic.Dde.Commands.Spectrum
{
    public class SpectrumCommandRequest<T> : SpectrumCommand, IDdeRequestCommand<T> where T : notnull
    {
        public SpectrumCommandRequest(string parameter) : base(parameter)
        {
        }
    }
}
