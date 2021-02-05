namespace Specshell.Omnic.Dde.Commands
{
    public class Display : IDdeExecuteCommand
    {
        public Display(string windowTitle = "")
        {
            Command = string.IsNullOrWhiteSpace(windowTitle) ? "[Display]" : $"[Display {windowTitle.DoubleDoubleQuote()}]";
        }

        public string Command { get; }
    }
}
