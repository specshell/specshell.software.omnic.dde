using NDde.Client;
using System;

namespace specshell.software.omnic.dde
{
    public class Dde
    {
        private static Dde _instance;

        public static Dde Instance()
        {
            if (_instance == null)
            {
                _instance = new Dde();
                _instance.Connect();
            }
            return _instance;
        }

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
            EnsureConnection();
            client.Execute(command, timeout);
        }

        public string ExecuteWithResponse(string command, int timeout = 500)
        {
            Execute(command, timeout);
            return ResultCurrent;
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

        private void EnsureConnection()
        {
            if (!client.IsConnected)
            {
                Console.WriteLine("The client did NOT have a connection! Attempting to connect");
                client.Connect();
                if (client.IsConnected)
                {
                    Console.WriteLine("The client successfully established a new connection");
                } 
                else 
                {
                    Console.WriteLine("The client failed to establish a new connection!");
                }
            }
        }
    }
}
