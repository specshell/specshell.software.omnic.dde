namespace Specshell.Omnic.Dde.Commands
{
    public class CollectSample : IDdeCommand
    {
        private readonly string _sampleTitle;

        internal CollectSample(string sampleTitle = "")
        {
            _sampleTitle = sampleTitle;
        }

        public string Command =>
            string.IsNullOrWhiteSpace(_sampleTitle) ? "[CollectSample]" : "[CollectSample \"\"" + _sampleTitle + "\"\"]";

        public string Data => string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}