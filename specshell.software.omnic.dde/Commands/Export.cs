namespace Specshell.Omnic.Dde.Commands
{
    public class Export : IDdeExecuteCommand, IPaths
    {
        public Export(string path = "")
        {
            FullPath = path.ToFullPath();
            ShortPath = FullPath.ToShortPath();
            Command = string.IsNullOrWhiteSpace(path) ? "[Export]" : $"[Export {ShortPath.DoubleDoubleQuote()}]";
        }

        public string Command { get; }
        public string FullPath { get; }
        public string ShortPath { get; }
    }
}
