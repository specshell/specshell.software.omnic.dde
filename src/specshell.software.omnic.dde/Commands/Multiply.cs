namespace Specshell.Omnic.Dde.Commands
{
    public class Multiply : IDdeExecuteCommand
    {
        public Multiply(float factor)
        {
            Command = $"[Multiply {factor}]";
        }

        public string Command { get; }
    }
}
