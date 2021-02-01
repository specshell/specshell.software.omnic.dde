namespace Specshell.Omnic.Dde.Commands
{
    public class Multiply : IDdeCommand
    {
        private readonly double _factor;

        internal Multiply(double factor = 0d)
        {
            _factor = factor;
        }

        public string Command => $"[Multiply {_factor}]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}