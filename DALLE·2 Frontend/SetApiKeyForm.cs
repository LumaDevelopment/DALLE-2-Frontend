using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DALLE_2_Frontend
{

    /**
     * Form that handles setting the API key, so the
     * main form can be a little bit cleaner.
     */
    public partial class SetApiKeyForm : Form
    {

        // Pass in DALLE2Frontend for SetAPIKey()
        private readonly DALLE2Frontend _mainForm;

        public SetApiKeyForm(DALLE2Frontend mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        /**
         * When the user clicks the link to get an API key,
         * open up the link in their web browser and set the link as visited.
         */
        private void getApiKeyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getApiKeyLink.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://platform.openai.com/account/api-keys") { UseShellExecute = true });
        }

        /**
         * When the user clicks the 'Set API Key' button, verify input
         * and set the API key in the main form. Then, close this form.
         */
        private void setApiKeyBtn_Click(object sender, EventArgs e)
        {

            // Input verification
            if (apiKeyBox.Text == "")
            {
                MessageBox.Show("There must be a value for the API key!", "Blank API Key", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Set API key
            _mainForm.SetAPIKey(apiKeyBox.Text);

            // Confirm API key set
            var res = MessageBox.Show("Set API Key to:\n" + apiKeyBox.Text.Trim(), "API Key Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                // Close out this form
                this.Close();
            }

        }

    }
}
