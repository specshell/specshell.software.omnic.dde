namespace Specshell.Omnic.Dde.Commands
{
    public class Multiply : IDdeExecuteCommand
    {
        private readonly double _factor;

        public Multiply(double factor = 0d)
        {
            _factor = factor;
        }

        public string Command => $"[Multiply {_factor}]";
    }
}