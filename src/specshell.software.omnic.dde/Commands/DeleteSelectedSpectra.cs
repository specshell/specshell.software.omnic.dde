namespace Specshell.Omnic.Dde.Commands;

public class DeleteSelectedSpectra : IDdeExecuteCommand
{
    public DeleteSelectedSpectra()
    {
        Command = "[DeleteSelectedSpectra]";
    }

    public string Command { get; }
}