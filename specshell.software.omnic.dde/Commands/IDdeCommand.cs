namespace Specshell.Omnic.Dde.Commands
{
    public interface IDdeCommand
    {
        string Command { get; }

        string Data { get; }

        CommandType Type { get; }
    }

    public enum CommandType
    {
        Execute,
        Poke,
        Request,
    }
}