namespace Specshell.Omnic.Dde.Commands;

public class NewWindow : IDdeExecuteCommand
{
    public NewWindow(string name)
    {
        Command = string.IsNullOrWhiteSpace(name) ? "[NewWindow]" : $"[NewWindow {name.DoubleQuote()}]";
    }

    public string Command { get; }
}