namespace Specshell.Omnic.Dde.Commands
{
    public class Display : IDdeCommand
    {
        private readonly string _windowTitle;

        internal Display(string windowTitle = "")
        {
            _windowTitle = windowTitle;
        }

        public string Command => string.IsNullOrWhiteSpace(_windowTitle) ? "[Display]" : $"[Display {_windowTitle}]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}