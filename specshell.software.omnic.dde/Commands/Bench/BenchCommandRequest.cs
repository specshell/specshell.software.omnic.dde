namespace Specshell.Omnic.Dde.Commands.Bench
{
    public class BenchCommandRequest<T> : BenchCommand, IDdeRequestCommand<T> where T : notnull
    {
        public BenchCommandRequest(string parameter) : base(parameter)
        {
        }
    }
}