namespace DALLE_2_Frontend
{
    partial class SetApiKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.getApiKeyLink = new System.Windows.Forms.LinkLabel();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.apiKeyBox = new System.Windows.Forms.TextBox();
            this.setApiKeyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Location = new System.Drawing.Point(13, 13);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(214, 13);
            this.instructionsLabel1.TabIndex = 0;
            this.instructionsLabel1.Text = "To use this program, you\'ll need an API key.";
            // 
            // getApiKeyLink
            // 
            this.getApiKeyLink.AutoSize = true;
            this.getApiKeyLink.Location = new System.Drawing.Point(13, 58);
            this.getApiKeyLink.Name = "getApiKeyLink";
            this.getApiKeyLink.Size = new System.Drawing.Size(135, 13);
            this.getApiKeyLink.TabIndex = 1;
            this.getApiKeyLink.TabStop = true;
            this.getApiKeyLink.Text = "Click me to get an API key!";
            this.getApiKeyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getApiKeyLink_LinkClicked);
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Location = new System.Drawing.Point(12, 35);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(329, 13);
            this.instructionsLabel2.TabIndex = 2;
            this.instructionsLabel2.Text = "This requires you have an OpenAPI account and have billing set up.";
            // 
            // apiKeyBox
            // 
            this.apiKeyBox.Location = new System.Drawing.Point(16, 86);
            this.apiKeyBox.Name = "apiKeyBox";
            this.apiKeyBox.Size = new System.Drawing.Size(325, 20);
            this.apiKeyBox.TabIndex = 3;
            // 
            // setApiKeyBtn
            // 
            this.setApiKeyBtn.Location = new System.Drawing.Point(16, 113);
            this.setApiKeyBtn.Name = "setApiKeyBtn";
            this.setApiKeyBtn.Size = new System.Drawing.Size(75, 23);
            this.setApiKeyBtn.TabIndex = 4;
            this.setApiKeyBtn.Text = "Set API Key";
            this.setApiKeyBtn.UseVisualStyleBackColor = true;
            this.setApiKeyBtn.Click += new System.EventHandler(this.setApiKeyBtn_Click);
            // 
            // SetApiKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 156);
            this.Controls.Add(this.setApiKeyBtn);
            this.Controls.Add(this.apiKeyBox);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.getApiKeyLink);
            this.Controls.Add(this.instructionsLabel1);
            this.Name = "SetApiKeyForm";
            this.Text = "Set API Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel1;
        private System.Windows.Forms.LinkLabel getApiKeyLink;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.TextBox apiKeyBox;
        private System.Windows.Forms.Button setApiKeyBtn;
    }
}