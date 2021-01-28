namespace Specshell.Omnic.Dde.Commands
{
    public class Select : ICommand
    {
        private readonly string _select;

        public Select(string select = "")
        {
            _select = select;
        }

        public string Command => string.IsNullOrWhiteSpace(_select) ? "[Select]" : $"[Select {_select}]";

        public CommandType Type => CommandType.Execute;
    }
}