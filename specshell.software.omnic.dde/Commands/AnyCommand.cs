namespace Specshell.Omnic.Dde.Commands
{
    public class AnyCommand : ICommand
    {
        public AnyCommand(string command, CommandType commandType)
        {
            Command = command;
            Type = commandType;
        }

        public string Command { get; }
        public CommandType Type { get; }

        public static CommandType GuessType(string command, string data = "")
        {
            if (!string.IsNullOrWhiteSpace(data))
            {
                return CommandType.Poke;
            }

            if (command.StartsWith("[") && command.EndsWith("]"))
            {
                return CommandType.Execute;
            }

            return CommandType.Request;
        }
    }
}