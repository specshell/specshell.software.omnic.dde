namespace Specshell.Omnic.Dde.Commands;

public class Import : IDdeExecuteCommand
{
    public Import(string path = "")
    {
        Command = string.IsNullOrWhiteSpace(path) ? "[Import]" : $"[Import {path.DoubleQuote()}]";
    }

    public string Command { get; }
}