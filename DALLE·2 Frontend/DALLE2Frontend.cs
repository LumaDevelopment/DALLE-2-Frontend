using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels.ResponseModels.ImageResponseModel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DALLE_2_Frontend
{
    public partial class DALLE2Frontend : Form
    {

        // User set API key
        private string _apiKey = "NO_API_KEY";
        private UserSettings _settings;

        // Generation progress form
        private GenerationProgressForm _currentGenerationProgressForm;

        // Generated image file paths and position tracking
        private string[] _imageFilePaths;
        private int _currentImageIndex = 0;

        // Price per image for each resolution (256x256, 
        // 512x512, and 1024x1024) in USD
        // Smart retrieval might be better at some point
        public static readonly decimal Price256 = 0.016M;
        public static readonly decimal Price512 = 0.018M;
        public static readonly decimal Price1024 = 0.02M;

        public DALLE2Frontend()
        {
            InitializeComponent();
        }

        /**
         * Called on form load, handles API key configuration and initializes generation cost
         */
        private void DALLE2Frontend_Load(object sender, EventArgs e)
        {

            _settings = new UserSettings();

            if (_settings.ApiKey != null)
            {
                _apiKey = _settings.ApiKey;
            }

            // Set default image resolution to 256x256
            imgResField.SelectedIndex = 0;

            UpdatePriceString();

        }

        /* ----- UI FUNCTIONS ----- */

        // Any time image resolution or number of pictures is changed, 
        // update the cost

        private void imgResField_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceString();
        }

        private void numOfPicturesField_ValueChanged(object sender, EventArgs e)
        {
            UpdatePriceString();
        }

        /**
         * Opens up a separate form where the user can set their API key
         */
        private void setAPIKeyBtn_Click(object sender, EventArgs e)
        {
            new SetApiKeyForm(this).Show();
        }

        /**
         * Called when the 'Generate!' button is clicked.
         * Does input verification, initializes the OpenAI API objects, and makes
         * the image generation call.
         */
        private async void generateBtn_ClickAsync(object sender, EventArgs e)
        {

            if (_apiKey == "NO_API_KEY")
            {
                // No API key
                MessageBox.Show("Please set your API key before generating.", "No API Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (promptBox.Text == "")
            {
                // Empty prompt
                MessageBox.Show("Please enter a prompt before generating.", "No Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentGenerationProgressForm = new GenerationProgressForm((int) numOfPicturesField.Value);
            _currentGenerationProgressForm.SetLabelText("Initializing API...");
            _currentGenerationProgressForm.Show();

            // Initialize OpenAI API object
            var openAIService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = _apiKey
            });

            _currentGenerationProgressForm.IncrementProgress("Making image generation request...");

            // Make generation request with user input
            var imageResult = await openAIService.Image.CreateImage(new ImageCreateRequest()
            {
                Prompt = promptBox.Text,
                N = (int)numOfPicturesField.Value,
                Size = imgResField.Text,
                ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url
            });

            if (imageResult.Successful)
            {

                _currentGenerationProgressForm.IncrementProgress("Handling request response...");

                // Image generated successfully, hand off images 
                // to be displayed in the UI
                HandleImageUrls(imageResult.Results);

            }
            else
            {

                // Shutdown progress form
                ShutdownGenerationProgressForm();

                // Error while generating
                MessageBox.Show(
                    "Error while generating:\n" + imageResult.Error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /**
         * Called when the user clicks the '<' button
         * Adjusts the visibility of the previous and next button,
         * and changes the image displayed in the picture box
         */
        private void prevButton_Click(object sender, EventArgs e)
        {

            // If this was the last image of the set, reveal the next button again
            if (_currentImageIndex == (_imageFilePaths.Length - 1))
            {
                nextButton.Visible = true;
            }

            // Show previous image
            _currentImageIndex--;
            pictureBox.Load(_imageFilePaths[_currentImageIndex]);

            // If we are now on the first image of the set, hide the previous button.
            if (_currentImageIndex == 0)
            {
                prevButton.Visible = false;
            }

        }

        /**
         * Called when the user clicks the '>' button
         * Adjusts the visibility of the previous and next button,
         * and changes the image displayed in the picture box
         */
        private void nextButton_Click(object sender, EventArgs e)
        {

            // If this was the first image of the set, reveal the previous button again
            if (_currentImageIndex == 0)
            {
                prevButton.Visible = true;
            }

            // Show next image
            _currentImageIndex++;
            pictureBox.Load(_imageFilePaths[_currentImageIndex]);

            // If we are now on the last image of the set, hide the next button.
            if (_currentImageIndex == (_imageFilePaths.Length - 1))
            {
                nextButton.Visible = false;
            }

        }

        /**
         * Called when the user clicks the 'Save Image' button
         * Allows the user to choose where to save the current image
         */
        private void saveImageBtn_Click(object sender, EventArgs e)
        {

            var saveFileDialog = new SaveFileDialog();

            // The returned image is always a PNG, so only allow the user to save in that format
            saveFileDialog.Filter = "PNG Image|*.png";

            saveFileDialog.Title = "Save Image";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {

                // If the user picked a file

                // Open a FileStream to that location
                var outputStream = (FileStream) saveFileDialog.OpenFile();

                // Save the image from the picture box to the chosen location
                pictureBox.Image.Save(outputStream, System.Drawing.Imaging.ImageFormat.Png);

                // Close the file stream
                outputStream.Close();

            }
            else
            {

                // If the user didn't pick a file, show an error message
                MessageBox.Show("Invalid file name!", "Invalid File Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /* ----- SUPPORT FUNCTIONS ----- */

        /**
         * Update the cost listed on the UI based on the user's chosen image resolution
         * and number of images to generate.
         */
        public void UpdatePriceString()
        {

            decimal price;

            // Get the price of the chosen image resolution
            switch (imgResField.Text)
            {
                case ("256x256"):
                    price = Price256;
                    break;
                case ("512x512"):
                    price = Price512;
                    break;
                case ("1024x1024"):
                    price = Price1024;
                    break;
                default:
                    price = -1;
                    break;
            }

            string priceString;

            if (price < 0)
            {
                // For some reason, the image resolution field was something other than the three options
                // Should be impossible, but always be prepared
                priceString = "ERROR";
            }
            else
            {
                // Set the price string equal to the resolution price multiplied by 
                // the number of pictures, formatted to three decimal places with a dollar sign
                priceString = "$" + (price * numOfPicturesField.Value).ToString("0.000");
            }

            requestCostText.Text = priceString;

        }

        /**
         * Sets the API key by both setting it in memory and also
         * saving it in user settings
         */
        public void SetAPIKey(string apiKey)
        {
            this._apiKey = apiKey.Trim();
            _settings.ApiKey = _apiKey;
            _settings.Save();
        }

        /**
         * Resets UI for new set of images, saves the image URLs, and loads the first image
         */
        private async void HandleImageUrls(List<ImageCreateResponse.ImageDataResult> imageDataResults)
        {

            // Save image URLs to temporary files
            _imageFilePaths = new string[imageDataResults.Count];
            var httpClient = new HttpClient();

            for (int i = 0; i < imageDataResults.Count; i++)
            {

                // Query image from the web
                var response = await httpClient.GetAsync(imageDataResults[i].Url);

                // Generate temporary file path
                var filePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

                // Open a file stream to temporary file path
                var fileStream = new FileStream(filePath, FileMode.CreateNew);

                // Copy from web to file path
                await response.Content.CopyToAsync(fileStream);

                // Close stream and save path to array
                fileStream.Close();
                _imageFilePaths[i] = filePath;

                _currentGenerationProgressForm.IncrementProgress(GenerationProgressForm.LabelBaseText + (i + 1) + "/" + imageDataResults.Count);

            }

            // Reset UI
            _currentImageIndex = 0;

            // First image, so no previous
            prevButton.Visible = false;

            // If the Save Image button wasn't visible already, make it so
            saveImageBtn.Visible = true;

            if (imageDataResults.Count > 1)
            {
                // If there is more than one image, show the next button
                nextButton.Visible = true;
            }
            else
            {
                // If there is only one image, the next button is not necessary
                nextButton.Visible = false;
            }

            // Get rid of the progress form
            _currentGenerationProgressForm.Close();
            ShutdownGenerationProgressForm();

            // Load first image
            pictureBox.Load(_imageFilePaths[_currentImageIndex]);

        }

        private void ShutdownGenerationProgressForm()
        {
            _currentGenerationProgressForm.Close();
            _currentGenerationProgressForm = null;
        }

    }

}
