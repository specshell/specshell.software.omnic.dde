namespace Specshell.Omnic.Dde.Commands
{
    public class AnyDdeCommand : IDdeCommand
    {
        public AnyDdeCommand(string command)
        {
            Command = command;
            GuessType();
        }

        public AnyDdeCommand(string command, string data)
        {
            Command = command;
            Data = data;
            Type = CommandType.Poke;
        }

        public AnyDdeCommand(string command, CommandType type, string data = "")
        {
            Command = command;
            Data = data;
            Type = type;
        }


        public string Command { get; }
        public CommandType Type { get; set; }

        public string Data { get; set; } = string.Empty;

        public void GuessType()
        {
            Type = GuessType(this);
        }

        public static CommandType GuessType(AnyDdeCommand cmd)
        {
            return GuessType(cmd.Command, cmd.Data);
        }

        public static CommandType GuessType(string cmd, string data = "")
        {
            if (!string.IsNullOrWhiteSpace(data))
            {
                return CommandType.Poke;
            }

            if (cmd.StartsWith("[") && cmd.EndsWith("]"))
            {
                return CommandType.Execute;
            }

            return CommandType.Request;
        }
    }
}