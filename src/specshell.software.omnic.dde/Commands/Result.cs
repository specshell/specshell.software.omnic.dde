namespace Specshell.Omnic.Dde.Commands
{
    public class Result : IDdeRequestCommand<string>
    {
        public Result(string parameter)
        {
            Command = $"Result {parameter}";
        }

        public static Result Current() => new Result("Current");

        public static Result Array() => new Result("Array");

        public static Result Error() => new Result("Error");

        public string Command { get; }
    }
}
