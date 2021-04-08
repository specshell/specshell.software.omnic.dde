namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectCommandPoke : CollectCommand, IDdePokeCommand
    {
        public CollectCommandPoke(string parameter, string data) : base(parameter)
        {
            Data = data;
        }

        public string Data { get; }
    }
}
