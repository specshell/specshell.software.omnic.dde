namespace Specshell.Omnic.Dde.Commands.Bench;

public class BenchCommand : IDdeCommand
{
    public BenchCommand(string parameter)
    {
        Command = $"BenchStatus {parameter}";
    }

    public string Command { get; }
}