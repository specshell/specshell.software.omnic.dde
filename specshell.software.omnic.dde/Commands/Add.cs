namespace Specshell.Omnic.Dde.Commands
{
    public class Add : ICommand
    {
        public string Command => "[Add]";

        public CommandType Type => CommandType.Execute;
    }
}