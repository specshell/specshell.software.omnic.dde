namespace Specshell.Omnic.Dde.Commands
{
    public class CutSelectedSpectra :  IDdeExecuteCommand
    {
        public CutSelectedSpectra()
        {
            Command = "[CutSelectedSpectra]";
        }

        public string Command { get; }
    }
}
