namespace Specshell.Omnic.Dde.Commands
{
    public class Multiply : IDdeExecuteCommand
    {
        public Multiply(double factor = 0d)
        {
            Command = $"[Multiply {factor}]";
        }

        public string Command { get; }
    }
}
