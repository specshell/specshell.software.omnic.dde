namespace Specshell.Omnic.Dde.Commands
{
    public class ResultCurrent : IDdeRequestCommand<string>
    {
        public string Command => "Result Current";
    }
}