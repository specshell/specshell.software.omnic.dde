using NDde.Client;
using System;

namespace Specshell.OmnicDde
{
    public class Dde
    {
        private DdeClient client;
        public readonly CommandsHandler CommandsHandler;

        public Dde()
        {
            client = new DdeClient("OMNIC", "SPECTRA");
            CommandsHandler = new CommandsHandler(this);
        }
        public void Connect()
        {
            client.Connect();
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
    }
}
