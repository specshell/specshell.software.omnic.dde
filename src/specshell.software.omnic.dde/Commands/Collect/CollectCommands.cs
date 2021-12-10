namespace Specshell.Omnic.Dde.Commands.Collect;

public static class CollectCommands
{
    public static CollectCommandRequest<string> GetFinalFormat() => new("FinalFormat");
    public static CollectCommandPoke SetFinalFormat(string data) => new("FinalFormat", data);

    public static CollectCommandPoke SetFinalFormatInterferogram() => SetFinalFormat("Interferogram");
    public static CollectCommandPoke SetFinalFormatAbsorbance() => SetFinalFormat("Absorbance");
    public static CollectCommandPoke SetFinalFormatSingleBeam() => SetFinalFormat("SingleBeam");

    public static CollectCommandRequest<string> GetBackgroundFileName() => new("BackgroundFileName");
    public static CollectCommandPoke SetBackgroundFileName(string fileName) => new("BackgroundFileName", fileName.ToShortPath());

    public static CollectCommandRequest<string> GetBackgroundHandling() => new("BackgroundHandling");
    public static CollectCommandPoke SetBackgroundHandlingToBeforeCollect() => new("BackgroundHandling", "BeforeCol");
    public static CollectCommandPoke SetBackgroundHandlingToAfterCollect() => new("BackgroundHandling", "AfterCol");
    public static CollectCommandPoke SetBackgroundHandlingToFile() => new("BackgroundHandling", "ThisBkg");
    public static CollectCommandPoke SetBackgroundHandlingToAge() => new("BackgroundHandling", "AfterTime");
    public static CollectCommandPoke SetBackgroundMaxAge(int minutes) => new("MaxBackgroundAge", $"{minutes}");

    public static CollectCommandRequest<int> GetNumberOfScans() => new("NumScans");
    public static CollectCommandPoke SetNumberOfScans(int number) => new("NumScans", number.ToString(CultureInfo.InvariantCulture));

    public static CollectCommandRequest<string> GetSaveInterferograms() => new("SaveInterferograms");
    public static CollectCommandPoke SetSaveInterferograms(bool save) => new("SaveInterferograms", save ? "TRUE" : "FALSE");

    public static CollectCommandRequest<string> GetDataCorrections() => new("DataCorrections");
    public static CollectCommandPoke SetDataCorrections(string correction) => new("DataCorrections", correction);

    public static CollectCommandPoke SetDataCorrectionAtmosphericSuppression() =>
        SetDataCorrections("Atmospheric suppression");

    public static CollectCommandPoke SetDataCorrectionNone() =>
        SetDataCorrections("None");
}
