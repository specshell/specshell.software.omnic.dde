namespace Specshell.Omnic.Dde.Commands.Bench
{
    public class BenchCommand : IDdeCommand
    {
        private readonly string _parameter;

        public BenchCommand(string parameter)
        {
            _parameter = parameter;
        }

        public string Command => $"BenchStatus {_parameter}";
    }
}