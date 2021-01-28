using System.Threading.Tasks;
using Specshell.Omnic.Dde.Commands;

namespace Specshell.Omnic.Dde
{
    public interface IOmnicDdeClient
    {
        Task<string> Execute(string command);
        Task<string> Poke(string item, string data);
        Task<string> Request(string item);
        Task<bool> Connect(bool retryConnect);
        Task Disconnect();
        Task<string> Run(ICommand command, string data = "");
    }
}