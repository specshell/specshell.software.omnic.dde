namespace Specshell.Omnic.Dde.Commands
{
    public class AutoTune : IDdeCommand
    {
        public string Command => "[Invoke AutoTune]";
        public string Data => string.Empty;
        public CommandType Type => CommandType.Execute;
    }
}