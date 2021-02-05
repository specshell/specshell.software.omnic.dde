namespace Specshell.Omnic.Dde
{
    public static class Extensions
    {
        public static string DoubleDoubleQuote(this string str) => str.Contains(' ') ? $"\"\"{str}\"\"" : str;

        public static string DoubleQuote(this string str) => str.Contains(' ') ? $"\"{str}\"" : str;
    }
}
