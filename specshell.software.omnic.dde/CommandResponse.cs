namespace Specshell.OmnicDde
{
    public class CommandResponse
    {
        public readonly bool Success;
        public readonly string ResultMessage;
        public readonly NDde.DdeException DdeException;

        public CommandResponse(bool success, string resultMessage, NDde.DdeException ddeException) 
        {
            Success = success;
            ResultMessage = resultMessage;
            DdeException = ddeException;
        }
        public bool ConnectionError()
        {
            return DdeException != null && DdeException.Message.Contains("The client failed to connect to");
        }
    }
}
