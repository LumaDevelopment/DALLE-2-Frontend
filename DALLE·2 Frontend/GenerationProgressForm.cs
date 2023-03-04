using System.Windows.Forms;

namespace DALLE_2_Frontend
{

    /**
     * A form which has a progress bar and a label to let users
     * know we're still doing work while they wait.
     */
    public partial class GenerationProgressForm : Form
    {

        // Used for text like: "Generating Image 3/7"
        public static string LabelBaseText = "Generating Image: ";

        // Keep track of bar progress and maximum
        private int _barProgress;
        private int _numOfImages;

        public GenerationProgressForm(int numOfImages)
        {

            InitializeComponent();

            this._barProgress = 0;

            // Add 2 to the number of images to account for 
            // completing API initialization and successfully 
            // receiving the request response
            this._numOfImages = numOfImages + 2;

            // Set progress bar UI values
            progressBar.Minimum = 0;
            progressBar.Maximum = _numOfImages;
            progressBar.Value = _barProgress;

        }

        /**
         * Set text of label without incrementing progress
         */
        public void SetLabelText(string labelText)
        {
            genImageLabel.Text = labelText;
        }

        /**
         * Set text of label and increment progress
         */
        public void IncrementProgress(string labelText)
        {

            _barProgress++;
            progressBar.Value = _barProgress;
            genImageLabel.Text = labelText;

        }

    }
}
