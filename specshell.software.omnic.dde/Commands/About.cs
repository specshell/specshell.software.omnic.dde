namespace Specshell.Omnic.Dde.Commands
{
    public class About : IDdeCommand
    {
        public string Command => "[About]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}