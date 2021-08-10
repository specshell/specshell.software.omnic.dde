namespace Specshell.Omnic.Dde.Commands
{
    public class SelectWindow : IDdeExecuteCommand
    {
        public SelectWindow(string name)
        {
            Command = string.IsNullOrWhiteSpace(name) ? "[SelectWindow]" : $"[SelectWindow {name.DoubleQuote()}]";
        }

        public string Command { get; }
    }
}
