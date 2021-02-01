namespace Specshell.Omnic.Dde.Commands
{
    public class Select : IDdeCommand
    {
        private readonly string _select;

        internal Select(string select = "")
        {
            _select = select;
        }

        internal static Select All() => new("All");

        public string Command => string.IsNullOrWhiteSpace(_select) ? "[Select]" : $"[Select {_select}]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}