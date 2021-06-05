namespace Specshell.Omnic.Dde.Commands.MenuStatus
{
    public static class MenuStatusCommands
    {
        public static MenuStatusCommandCommandRequest<bool> CollectSample() => new("CollectSample");
        public static MenuStatusCommandCommandRequest<bool> CollectBackground() => new("CollectBackground");
    }
}
