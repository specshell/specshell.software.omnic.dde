namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectCommandRequest<T> : CollectCommand, IDdeRequestCommand<T> where T : notnull
    {
        public CollectCommandRequest(string parameter) : base(parameter)
        {
        }
    }
}
