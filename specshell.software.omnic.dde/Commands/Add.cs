namespace Specshell.Omnic.Dde.Commands
{
    public class Add : IDdeCommand
    {
        public string Command => "[Add]";

        public CommandType Type => CommandType.Execute;
    }
}