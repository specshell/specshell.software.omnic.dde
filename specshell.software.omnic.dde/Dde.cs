using NDde.Client;

namespace specshell.software.omnic.dde
{
    class Dde
    {
        private DdeClient client;

        public Dde()
        {
            client = new DdeClient("OMNIC", "SPECTRA");
        }
        public void Connect()
        {
            client.Connect();
        }

        public void Execute(string command, int timeout = 500)
        {
            client.Execute(command, timeout);
        }
        public string Request(string item, int timeout = 500)
        {
            return client.Request(item, timeout);
        }

        public string ResultCurrent => Request("Result Current", 1000);

        public void Poke(string item, string data, int timeout = 500)
        {
            client.Poke(item, data, timeout);
        }
    }
}
