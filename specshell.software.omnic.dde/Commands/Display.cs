namespace Specshell.Omnic.Dde.Commands
{
    public class Display : IDdeExecuteCommand
    {
        public Display(string windowTitle = "")
        {
            Command = string.IsNullOrWhiteSpace(windowTitle) ? "[Display]" : $"[Display {windowTitle}]";
        }

        public string Command { get; }
    }
}
