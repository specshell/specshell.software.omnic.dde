namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectCommand : IDdeCommand
    {
        public CollectCommand(string parameter)
        {
            Command = $"Collect {parameter}";
        }

        public string Command { get; }
    }
}
