namespace Specshell.Omnic.Dde.Commands.Bench;

public static class BenchStatusCommands
{
    public static BenchCommandRequest<float> GetBoardTemperature() => new("BoardTemp");
    public static BenchCommandRequest<float> GetModulatorTemperature() => new("ModulTemp");
    public static BenchCommandRequest<float> GetHumidity() => new("Humidity");
    public static BenchCommandRequest<float> GetLaserMilliampere() => new("LaserCur");
    public static BenchCommandRequest<float> GetLaserTemperature() => new("LaserTemp");
    public static BenchCommandRequest<float> GetLaserR() => new("LaserR");
    public static BenchCommandRequest<float> GetLaserX() => new("LaserX");
    public static BenchCommandRequest<float> GetLaserY() => new("LaserY");
    public static BenchCommandRequest<float> GetInfraredSourceAmpere() => new("IRSrcCur");
    public static BenchCommandRequest<float> GetInfraredSourceVolt() => new("IRSrcPwr");
}