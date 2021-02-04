namespace Specshell.Omnic.Dde.Commands
{
    public interface IDdeRequestCommand<out T> : IDdeCommand where T : notnull
    {
    }
}