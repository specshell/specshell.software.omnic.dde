namespace Specshell.Omnic.Dde.Commands
{
    public class DeleteSelectedSpectra : IDdeCommand
    {
        public string Command => "[DeleteSelectedSpectra]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}