namespace Specshell.Omnic.Dde.Commands
{
    public class Select : IDdeExecuteCommand
    {
        public Select(string select = "")
        {
            Command = string.IsNullOrWhiteSpace(select) ? "[Select]" : $"[Select {select}]";
        }

        public string Command { get; }

        public static Select All() => new("All");
    }
}
