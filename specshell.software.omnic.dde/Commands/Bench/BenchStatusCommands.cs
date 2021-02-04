namespace Specshell.Omnic.Dde.Commands.Bench
{
    public static class BenchStatusCommands
    {
        public static BenchCommandRequest<string> GetBoardTemperature() => new("BoardTemp");
        public static BenchCommandRequest<string> GetModulatorTemperature() => new("ModulTemp");
        public static BenchCommandRequest<string> GetHumidity() => new("Humidity");
        public static BenchCommandRequest<string> GetLaserMilliampere() => new("LaserCur");
        public static BenchCommandRequest<string> GetLaserTemperature() => new("LaserTemp");
        public static BenchCommandRequest<string> GetLaserR() => new("LaserR");
        public static BenchCommandRequest<string> GetLaserX() => new("LaserX");
        public static BenchCommandRequest<string> GetLaserY() => new("LaserY");
        public static BenchCommandRequest<string> GetInfraredSourceAmpere() => new("IRSrcCur");
        public static BenchCommandRequest<string> GetInfraredSourceVolt() => new("IRSrcPwr");
    }
}