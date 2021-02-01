namespace Specshell.Omnic.Dde.Commands
{
    public class ResultCurrent : IDdeCommand
    {
        public string Command => "Result Current";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Request;
    }
}