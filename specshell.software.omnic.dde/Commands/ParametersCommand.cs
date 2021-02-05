namespace Specshell.Omnic.Dde.Commands
{
    public class ParametersCommand : IDdeExecuteCommand, IPaths
    {
        private ParametersCommand(string path, string method)
        {
            FullPath = path.ToFullPath();
            ShortPath = FullPath.ToShortPath();
            Command = $"[{method} {ShortPath.DoubleDoubleQuote()}]";
        }

        public string Command { get; }

        public static ParametersCommand SaveParameters(string path) => new(path, "SaveParameters");
        public static ParametersCommand LoadParameters(string path) => new(path, "LoadParameters");
        public string FullPath { get; }
        public string ShortPath { get; }
    }
}
