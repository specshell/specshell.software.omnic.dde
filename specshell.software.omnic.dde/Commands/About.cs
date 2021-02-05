namespace Specshell.Omnic.Dde.Commands
{
    public class About : IDdeExecuteCommand
    {
        public About()
        {
            Command = "[About]";
        }

        public string Command { get; }
    }
}
