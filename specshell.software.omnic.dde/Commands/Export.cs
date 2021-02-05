namespace Specshell.Omnic.Dde.Commands
{
    public class Export : IDdeExecuteCommand
    {
        public Export(string path = "")
        {
            Command = string.IsNullOrWhiteSpace(path) ? "[Export]" : $"[Export {path}]";
        }

        public string Command { get; }
    }
}
