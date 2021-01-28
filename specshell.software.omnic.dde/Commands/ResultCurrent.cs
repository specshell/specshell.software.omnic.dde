namespace Specshell.Omnic.Dde.Commands
{
    public class ResultCurrent : ICommand
    {
        public string Command => "Result Current";

        public CommandType Type => CommandType.Request;
    }
}