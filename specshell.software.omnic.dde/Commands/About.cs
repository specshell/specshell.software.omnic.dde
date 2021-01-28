namespace Specshell.Omnic.Dde.Commands
{
    public class About : ICommand
    {
        public string Command => "[About]";

        public CommandType Type => CommandType.Execute;
    }
}