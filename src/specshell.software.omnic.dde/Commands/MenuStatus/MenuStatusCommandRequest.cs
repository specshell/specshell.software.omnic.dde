namespace Specshell.Omnic.Dde.Commands.MenuStatus;

public class MenuStatusCommandCommandRequest<T> : MenuStatusCommand, IDdeRequestCommand<T> where T : notnull
{
    public MenuStatusCommandCommandRequest(string parameter) : base(parameter)
    {
    }
}