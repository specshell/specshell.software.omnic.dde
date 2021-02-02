namespace Specshell.Omnic.Dde.Commands
{
    public class BenchStatus : IDdeCommand
    {
        private readonly string _parameter;
        private BenchStatus(string parameter)
        {
            _parameter = parameter;
        }

        internal static BenchStatus BoardTemperature() => new ("BoardTemp");
        internal static BenchStatus ModulatorTemperature() => new("ModulTemp");
        internal static BenchStatus Humidity() => new ("Humidity");
        internal static BenchStatus LaserMilliampere() => new ("LaserCur");
        internal static BenchStatus LaserTemperature() => new("LaserTemp");
        internal static BenchStatus LaserR() => new("LaserR");
        internal static BenchStatus LaserX() => new("LaserX");
        internal static BenchStatus LaserY() => new("LaserY");
        internal static BenchStatus InfraredSourceAmpere() => new ("IRSrcCur");
        internal static BenchStatus InfraredSourceVolt() => new ("IRSrcPwr");

        public string Command => $"BenchStatus {_parameter}";
        public string Data => string.Empty;
        public CommandType Type => CommandType.Request;
    }
}