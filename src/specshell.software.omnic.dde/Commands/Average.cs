namespace Specshell.Omnic.Dde.Commands
{
    public class Average : IDdeExecuteCommand
    {
        public Average()
        {
            Command = "[Average]";
        }

        public string Command { get; }
    }
}
