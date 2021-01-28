namespace Specshell.Omnic.Dde.Commands
{
    public class About : IDdeCommand
    {
        public string Command => "[About]";

        public CommandType Type => CommandType.Execute;
    }
}