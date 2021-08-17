namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectSample : IDdeExecuteCommand
    {
        public CollectSample(string sampleTitle = "")
        {
            Command = string.IsNullOrWhiteSpace(sampleTitle)
                ? "[CollectSample]"
                : $@"[CollectSample {sampleTitle.DoubleQuote()}]";
        }

        public string Command { get; }
    }
}
