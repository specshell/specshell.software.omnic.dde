namespace Specshell.Omnic.Dde.Commands
{
    public class DeleteSelectedSpectra : ICommand
    {
        public DeleteSelectedSpectra()
        {
        }

        public string Command => "[DeleteSelectedSpectra]";

        public CommandType Type => CommandType.Execute;
    }
}