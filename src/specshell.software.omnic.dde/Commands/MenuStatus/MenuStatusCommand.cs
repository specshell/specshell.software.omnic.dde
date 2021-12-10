namespace Specshell.Omnic.Dde.Commands.MenuStatus;

public class MenuStatusCommand : IDdeRequestCommand<string>
{
    public MenuStatusCommand(string parameter)
    {
        Command = $"MenuStatus {parameter}";
    }

    public string Command { get; }
}