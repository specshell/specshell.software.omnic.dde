namespace Specshell.Omnic.Dde.Commands.Alignment
{
    public class AutoTune : IDdeExecuteCommand
    {
        public AutoTune()
        {
            Command = "[Invoke AutoTune]";
        }

        public string Command { get; }
    }
}
