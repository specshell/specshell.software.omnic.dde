namespace Specshell.Omnic.Dde.Commands;

public class Reprocess : IDdeExecuteCommand
{
    public Reprocess()
    {
        Command = "[Reprocess]";
    }

    public string Command { get; }
}
