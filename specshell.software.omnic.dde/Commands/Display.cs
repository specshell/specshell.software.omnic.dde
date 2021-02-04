namespace Specshell.Omnic.Dde.Commands
{
    public class Display : IDdeExecuteCommand
    {
        private readonly string _windowTitle;

        public Display(string windowTitle = "")
        {
            _windowTitle = windowTitle;
        }

        public string Command => string.IsNullOrWhiteSpace(_windowTitle) ? "[Display]" : $"[Display {_windowTitle}]";
    }
}