namespace Specshell.Omnic.Dde.Commands
{
    public class Export : IDdeExecuteCommand
    {
        private readonly string _path;

        public Export(string path = "")
        {
            _path = path;
        }

        public string Command => string.IsNullOrWhiteSpace(_path) ? "[Export]" : $"[Export {_path}]";
    }
}