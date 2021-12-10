namespace Specshell.Omnic.Dde.Commands;

public class Export : IDdeExecuteCommand
{
    public Export(string path = "")
    {
        Command = string.IsNullOrWhiteSpace(path) ? "[Export]" : $"[Export {path.DoubleQuote()}]";
    }

    public string Command { get; }
}