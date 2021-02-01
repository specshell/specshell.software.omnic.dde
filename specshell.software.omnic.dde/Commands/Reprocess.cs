namespace Specshell.Omnic.Dde.Commands
{
    public class Reprocess : IDdeCommand
    {
        public string Command => "[Reprocess]";
        public string Data => string.Empty;
        public CommandType Type => CommandType.Execute;
    }
}