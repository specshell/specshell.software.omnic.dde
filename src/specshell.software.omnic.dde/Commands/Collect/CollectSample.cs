namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectSample : IDdeExecuteCommand
    {
        public CollectSample(string sampleTitle = "")
        {
            Command = string.IsNullOrWhiteSpace(sampleTitle)
                ? "[Invoke CollectSample Auto]"
                : $@"[Invoke CollectSample {sampleTitle.DoubleQuote()} Auto]";
        }

        public string Command { get; }
    }
}
