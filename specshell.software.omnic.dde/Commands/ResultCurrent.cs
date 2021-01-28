namespace Specshell.Omnic.Dde.Commands
{
    public class ResultCurrent : IDdeCommand
    {
        public string Command => "Result Current";

        public CommandType Type => CommandType.Request;
    }
}