using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NDde;
using NDde.Client;

namespace Specshell.OmnicDde
{
    public class OmnicDdeClient : IOmnicDdeClient
    {
        private readonly ILogger<OmnicDdeClient> _logger;
        private DdeClient client;

        public OmnicDdeClient(ILogger<OmnicDdeClient> logger)
        {
            _logger = logger;
            client = new DdeClient("OMNIC", "SPECTRA");
        }

        public void Connect()
        {
            client.Connect();
            client.Disconnected += OnDisconnected;
        }

        private async void OnDisconnected(object? sender, DdeDisconnectedEventArgs e)
        {
            while (!client.IsConnected)
            {
                try
                {
                    client.Connect();
                    if (!client.IsConnected) await Task.Delay(1000);
                }
                catch (DdeException ex)
                {
                    _logger.Log(LogLevel.Information, "Connection attempt failed, retrying", ex);
                }
                catch (InvalidOperationException)
                {
                    _logger.Log(LogLevel.Trace, "Already connected");
                }
            }
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
