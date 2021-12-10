namespace Specshell.Omnic.Dde.Commands;

public interface IDdePokeCommand : IDdeCommand
{
    string Data { get; }
}