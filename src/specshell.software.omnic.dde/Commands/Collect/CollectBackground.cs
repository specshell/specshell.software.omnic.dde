namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectBackground : IDdeExecuteCommand
    {
        public CollectBackground(string sampleTitle = "")
        {
            Command = string.IsNullOrWhiteSpace(sampleTitle)
                ? "[Invoke CollectBackground Auto]"
                : $@"[Invoke CollectBackground {sampleTitle.DoubleQuote()} Auto]";
        }

        public string Command { get; }
    }
}
