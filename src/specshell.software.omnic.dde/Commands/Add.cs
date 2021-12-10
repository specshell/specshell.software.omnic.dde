namespace Specshell.Omnic.Dde.Commands;

public class Add : IDdeExecuteCommand
{
    public Add()
    {
        Command = "[Add]";
    }

    public string Command { get; }
}