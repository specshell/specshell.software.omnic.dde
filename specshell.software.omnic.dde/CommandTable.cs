namespace Specshell.OmnicDde
{
    public class CommandTable
    {
        private readonly Dde dde;

        public CommandTable(Dde dde)
        {
            this.dde = dde;
        }


        /// <summary>
        /// This command retrieves version and copyright information for OMNIC and sets Result Current to About string. If invoked, the About Dialog box appears.
        /// </summary>
        public string About()
        {
            dde.Execute("[About]");
            return dde.ResultCurrent;
        }

        /// <summary>
        /// This command adds the two selected spectra together to produce a new spectrum.
        ///
        /// Throws exception if not exactly two spectra is selected.
        /// </summary>
        public void Add()
        {
            dde.Execute("[Add]");
        }


        /// <summary>
        /// This command initiates a sample data collection.
        /// </summary>
        public void CollectSample(string sampleTitle)
        {
            dde.Execute("[CollectSample \"\"" + sampleTitle + "\"\"]");
        }


        /// <summary>
        /// This command moves all spectra from the hidden DDE window to the current active spectral window or the specified spectral window.
        /// </summary>
        public void Display(string windowTitle = null)
        {
            string command = windowTitle == null ? "[Display]" : "[Display " + windowTitle + "]";
            dde.Execute(command);
        }

        /// <summary>
        /// This command multiplies the entire spectrum by a factor and produces a new spectrum in the active spectral window.
        /// </summary>
        public void Multiply(double factor)
        {
            dde.Execute("[Multiply " + factor + "]");
        }

        /// <summary>
        /// This command is not documented in the pdf.
        ///
        /// This command performs an advanced atr correction on the current selected spectrum.
        ///
        /// </summary>
        public void AdvancedAtr(double crystalRefractiveIndex, double angleOfIncidenceDegrees, double numberOfBounces, double sampleRefractiveIndex)
        {
            dde.Execute("[AdvancedATR " + crystalRefractiveIndex + " " + angleOfIncidenceDegrees + " " + numberOfBounces + " " + sampleRefractiveIndex + "]", 5000);
        }


        /// <summary>
        /// This command saved the selected spectrum on a disk. If no filename is specified the operator will be prompted for a filename.
        ///
        /// The given filename must contain the entire path and the filename with the file extension. The given file extension determines the file type exported.
        /// </summary>
        public void Export(string filename = null)
        {
            string command = filename == null ? "[Export]" : "[Export " + filename + "]";
            dde.Execute(command);
        }

        public void SelectAll()
        {
            dde.Execute("[Select All]");
        }

        public void DeleteSelectedSpectra()
        {
            dde.Execute("[DeleteSelectedSpectra]");
        }
    }
}
