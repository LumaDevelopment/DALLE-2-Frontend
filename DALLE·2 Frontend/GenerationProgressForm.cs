using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALLE_2_Frontend
{
    public partial class GenerationProgressForm : Form
    {

        public static string LabelBaseText = "Generating Image: ";
        private int _barProgress;
        private int _numOfImages;

        public GenerationProgressForm(int numOfImages)
        {
            InitializeComponent();

            this._barProgress = 0;
            this._numOfImages = numOfImages + 2;

            progressBar.Minimum = 0;
            progressBar.Maximum = _numOfImages;
            progressBar.Value = _barProgress;

        }

        public void SetLabelText(string labelText)
        {
            genImageLabel.Text = labelText;
        }

        public void IncrementProgress(string labelText)
        {

            _barProgress++;
            progressBar.Value = _barProgress;
            genImageLabel.Text = labelText;

        }

    }
}
