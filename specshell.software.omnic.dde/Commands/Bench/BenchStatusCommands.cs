namespace Specshell.Omnic.Dde.Commands.Bench
{
    public static class BenchStatusCommands
    {
        public static BenchCommandRequest<double> GetBoardTemperature() => new("BoardTemp");
        public static BenchCommandRequest<double> GetModulatorTemperature() => new("ModulTemp");
        public static BenchCommandRequest<double> GetHumidity() => new("Humidity");
        public static BenchCommandRequest<double> GetLaserMilliampere() => new("LaserCur");
        public static BenchCommandRequest<double> GetLaserTemperature() => new("LaserTemp");
        public static BenchCommandRequest<double> GetLaserR() => new("LaserR");
        public static BenchCommandRequest<double> GetLaserX() => new("LaserX");
        public static BenchCommandRequest<double> GetLaserY() => new("LaserY");
        public static BenchCommandRequest<double> GetInfraredSourceAmpere() => new("IRSrcCur");
        public static BenchCommandRequest<double> GetInfraredSourceVolt() => new("IRSrcPwr");
    }
}
