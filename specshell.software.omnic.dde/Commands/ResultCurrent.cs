namespace Specshell.Omnic.Dde.Commands
{
    public class ResultCurrent : IDdeRequestCommand<string>
    {
        public ResultCurrent()
        {
            Command = "Result Current";
        }

        public string Command { get; }
    }
}
