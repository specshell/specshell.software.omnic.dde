namespace Specshell.Omnic.Dde.Commands
{
    public class CollectSample : IDdeCommand
    {
        private readonly string _sampleTitle;

        public CollectSample(string sampleTitle = "")
        {
            _sampleTitle = sampleTitle;
        }

        public string Command => string.IsNullOrWhiteSpace(_sampleTitle) ? "[CollectSample]" : "[CollectSample \"\"" + _sampleTitle + "\"\"]";

        public CommandType Type => CommandType.Execute;
    }
}