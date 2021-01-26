using NDde.Client;

namespace Specshell.OmnicDde
{
    public class OmnicDdeClient : IOmnicDdeClient
    {
        private DdeClient client;

        public OmnicDdeClient()
        {
            client = new DdeClient("OMNIC", "SPECTRA");
        }

        public void Connect()
        {
            client.Connect();
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public void Execute(string command, int timeout = 500)
        {
            client.Execute(command, timeout);
        }

        public void Poke(string item, string data, int timeout = 500)
        {
            client.Poke(item, data, timeout);
        }

        public string Request(string item, int timeout = 500)
        {
            return client.Request(item, timeout);
        }

        public string ResultCurrent => Request("Result Current", 1000);


        public string About()
        {
            Execute("[About]");
            return ResultCurrent;
        }

        public void Add()
        {
            Execute("[Add]");
        }

        public void CollectSample(string sampleTitle)
        {
            Execute("[CollectSample \"\"" + sampleTitle + "\"\"]");
        }

        public void Display(string windowTitle = null)
        {
            string command = windowTitle == null ? "[Display]" : "[Display " + windowTitle + "]";
            Execute(command);
        }

        public void Multiply(double factor)
        {
            Execute("[Multiply " + factor + "]");
        }

        public void AdvancedAtr(double crystalRefractiveIndex, double angleOfIncidenceDegrees, double numberOfBounces, double sampleRefractiveIndex)
        {
            Execute("[AdvancedATR " + crystalRefractiveIndex + " " + angleOfIncidenceDegrees + " " + numberOfBounces + " " + sampleRefractiveIndex + "]", 5000);
        }


        public void Export(string filename = null)
        {
            string command = filename == null ? "[Export]" : "[Export " + filename + "]";
            Execute(command);
        }

        public void SelectAll()
        {
            Execute("[Select All]");
        }

        public void DeleteSelectedSpectra()
        {
            Execute("[DeleteSelectedSpectra]");
        }
    }
}
