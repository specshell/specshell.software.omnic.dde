using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NDde;
using NDde.Client;
using Specshell.Omnic.Dde.Commands;

namespace Specshell.Omnic.Dde
{
    public class OmnicDdeClient : IOmnicDdeClient
    {
        private readonly ILogger<OmnicDdeClient> _logger;
        private DdeClient client;
        private int _timeout;

        public TimeSpan Timeout
        {
            get => TimeSpan.FromMilliseconds(_timeout);
            set => _timeout = (int) value.TotalMilliseconds;
        }

        public OmnicDdeClient(ILogger<OmnicDdeClient> logger)
        {
            _logger = logger;
            client = new DdeClient("OMNIC", "SPECTRA");
            Timeout = TimeSpan.FromMinutes(10);
        }

        public async Task<bool> Connect(bool retryConnect)
        {
            var connected = false;
            if (retryConnect)
            {
                while (!connected)
                {
                    try
                    {
                        await Task.Run(() => client.Connect());
                        connected = client.IsConnected;
                        if (connected) _logger.LogInformation("Connected");
                        else await Task.Delay(500);
                    }
                    catch (DdeException)
                    {
                        _logger.LogDebug("Failed to connect, retrying");
                    }
                    catch (InvalidOperationException)
                    {
                        connected = client.IsConnected;
                    }
                    catch (Exception e)
                    {
                        _logger.LogWarning("Unknown exception thrown", e);
                    }
                }
            }
            else
            {
                try
                {
                    await Task.Run(() => client.Connect());
                    connected = client.IsConnected;
                    _logger.LogInformation("Connected");
                }
                catch (InvalidOperationException)
                {
                    connected = client.IsConnected;
                    _logger.LogDebug("Already connected");
                }
            }

            return connected;
        }

        public Task Disconnect()
        {
            return Task.Run(() => client.Disconnect());
        }

        public async Task<string> Execute(string command)
        {
            await Task.Run(() => client.Execute(command, _timeout));
            return "";
        }

        public async Task<string> Poke(string item, string data)
        {
            await Task.Run(() => client.Poke(item, data, _timeout));
            return "";
        }

        public Task<string> Request(string item) => Task.Run(() => client.Request(item, _timeout));

        public async Task<string> Run(ICommand command, string data = "")
        {
            var cmd = command.Command;

            return command.Type switch
            {
                CommandType.Execute => await Execute(cmd),
                CommandType.Poke => await Poke(cmd, data),
                CommandType.Request => await Request(cmd),
                _ => "",
            };
        }
    }
}