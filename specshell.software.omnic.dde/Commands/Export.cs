namespace Specshell.Omnic.Dde.Commands
{
    public class Export : ICommand
    {
        private readonly string _filename;

        public Export(string filename = "")
        {
            _filename = filename;
        }

        public string Command => string.IsNullOrWhiteSpace(_filename) ? "[Export]" : $"[Export {_filename}]";

        public CommandType Type => CommandType.Execute;
    }
}