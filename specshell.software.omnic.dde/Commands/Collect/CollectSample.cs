namespace Specshell.Omnic.Dde.Commands.Collect
{
    public class CollectSample : IDdeExecuteCommand
    {
        private readonly string _sampleTitle;

        public CollectSample(string sampleTitle = "")
        {
            _sampleTitle = sampleTitle;
        }

        public string Command =>
            string.IsNullOrWhiteSpace(_sampleTitle) ? "[CollectSample]" : "[CollectSample \"\"" + _sampleTitle + "\"\"]";
    }
}