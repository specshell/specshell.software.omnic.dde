namespace Specshell.OmnicDde
{
    public interface IOmnicDdeClient
    {
        void Connect();
        void Execute(string command, int timeout = 500);
        void Poke(string item, string data, int timeout = 500);
        string Request(string item, int timeout = 500);
        string ResultCurrent { get; }

        /// <summary>
        /// This command retrieves version and copyright information for OMNIC and sets Result Current to About string. If invoked, the About Dialog box appears.
        /// </summary>
        string About();

        /// <summary>
        /// This command adds the two selected spectra together to produce a new spectrum.
        ///
        /// Throws exception if not exactly two spectra is selected.
        /// </summary>
        void Add();

        /// <summary>
        /// This command initiates a sample data collection.
        /// </summary>
        void CollectSample(string sampleTitle);

        /// <summary>
        /// This command moves all spectra from the hidden DDE window to the current active spectral window or the specified spectral window.
        /// </summary>
        void Display(string windowTitle = null);

        /// <summary>
        /// This command multiplies the entire spectrum by a factor and produces a new spectrum in the active spectral window.
        /// </summary>
        void Multiply(double factor);

        /// <summary>
        /// This command is not documented in the pdf.
        ///
        /// This command performs an advanced atr correction on the current selected spectrum.
        ///
        /// </summary>
        void AdvancedAtr(double crystalRefractiveIndex, double angleOfIncidenceDegrees, double numberOfBounces, double sampleRefractiveIndex);

        /// <summary>
        /// This command saved the selected spectrum on a disk. If no filename is specified the operator will be prompted for a filename.
        ///
        /// The given filename must contain the entire path and the filename with the file extension. The given file extension determines the file type exported.
        /// </summary>
        void Export(string filename = null);

        void SelectAll();
        void DeleteSelectedSpectra();
        void Disconnect();
    }
}