namespace Specshell.Omnic.Dde.Commands
{
    public class Paste :  IDdeExecuteCommand
    {
        public Paste()
        {
            Command = "[Paste]";
        }

        public string Command { get; }
    }
}
