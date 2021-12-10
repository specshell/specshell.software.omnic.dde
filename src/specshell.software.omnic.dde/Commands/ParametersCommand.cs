namespace Specshell.Omnic.Dde.Commands;

public class ParametersCommand : IDdeExecuteCommand
{
    private ParametersCommand(string path, string method)
    {
        Command = $"[{method} {path.DoubleQuote()}]";
    }

    public string Command { get; }

    public static ParametersCommand SaveParameters(string path) => new(path, "SaveParameters");
    public static ParametersCommand LoadParameters(string path) => new(path, "LoadParameters");
}