namespace Specshell.Omnic.Dde.Commands
{
    public class Add : IDdeCommand
    {
        public string Command => "[Add]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}