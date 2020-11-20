namespace specshell.software.omnic.dde
{
    public class Commands
    {
        /// <summary>
        /// This command retrieves version and copyright information for OMNIC and sets Result Current to About string. If invoked, the About Dialog box appears.
        /// </summary>
        public static string About()
        {
            return Dde.Instance().ExecuteWithResponse("[About]");
        }

        /// <summary>
        /// This command adds the two selected spectra together to produce a new spectrum.
        /// 
        /// Throws exception if not exactly two spectra is selected.
        /// </summary>
        public static string Add()
        {
            return Dde.Instance().ExecuteWithResponse("[Add]");
        }


        /// <summary>
        /// This command initiates a sample data collection.
        /// </summary>
        public static string CollectSample(string sampleTitle) 
        {
            return Dde.Instance().ExecuteWithResponse("[CollectSample\"\"" + sampleTitle + "\"\"]");
        }


        /// <summary>
        /// This command moves all spectra from the hidden DDE window to the current active spectral window or the specified spectral window.
        /// </summary>
        public static string Display(string windowTitle = null) 
        {
            string command = windowTitle == null ? "[Display]" : "[Display " + windowTitle + "]";
            return Dde.Instance().ExecuteWithResponse(command);
        }

        /// <summary>
        /// This command multiplies the entire spectrum by a factor and produces a new spectrum in the active spectral window.
        /// </summary>
        public static string Multiply(double factor)
        {
            return Dde.Instance().ExecuteWithResponse("[Multiply " + factor + "]");
        }

        /// <summary>
        /// This command is not documented in the pdf.
        /// 
        /// This command performs an advanced atr correction on the current selected spectrum.
        /// 
        /// </summary>
        public static void AdvancedAtr(double crystalRefractiveIndex, double angleOfIncidenceDegrees, double numberOfBounces, double sampleRefractiveIndex)
        {
            // Does not return a message
            Dde.Instance().ExecuteWithResponse("[AdvancedATR " + crystalRefractiveIndex + " " + angleOfIncidenceDegrees + " " + numberOfBounces + " " + sampleRefractiveIndex + "]", 5000);
        }


        /// <summary>
        /// This command saved the selected spectrum on a disk. If no filename is specified the operator will be prompted for a filename.
        /// 
        /// The given filename must contain the entire path and the filename with the file extension. The given file extension determines the file type exported. 
        /// </summary>
        public static void Export(string filename = null)
        {
            string command = filename == null ? "[Export]" : "[Export " + filename + "]";
            Dde.Instance().ExecuteWithResponse(command);
        }

        public static void SelectAll()
        {
            Dde.Instance().ExecuteWithResponse("[Select All]");
        }

        public static void DeleteSelectedSpectra()
        {
            Dde.Instance().ExecuteWithResponse("[DeleteSelectedSpectra]");
        }
    }
}
