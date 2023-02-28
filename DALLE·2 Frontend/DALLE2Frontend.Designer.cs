namespace DALLE_2_Frontend
{
    partial class DALLE2Frontend
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
            promptLabel = new System.Windows.Forms.Label();
            promptBox = new System.Windows.Forms.TextBox();
            imageLabel = new System.Windows.Forms.Label();
            saveImageBtn = new System.Windows.Forms.Button();
            numOfPicturesField = new System.Windows.Forms.NumericUpDown();
            numOfPicturesLabel = new System.Windows.Forms.Label();
            imgResField = new System.Windows.Forms.ComboBox();
            imgResLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            requestCostText = new System.Windows.Forms.Label();
            generateBtn = new System.Windows.Forms.Button();
            setAPIKeyBtn = new System.Windows.Forms.Button();
            pictureBox = new System.Windows.Forms.PictureBox();
            prevButton = new System.Windows.Forms.Button();
            nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numOfPicturesField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new System.Drawing.Point(10, 16);
            promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new System.Drawing.Size(50, 15);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Prompt:";
            // 
            // promptBox
            // 
            promptBox.Location = new System.Drawing.Point(14, 35);
            promptBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            promptBox.Multiline = true;
            promptBox.Name = "promptBox";
            promptBox.Size = new System.Drawing.Size(318, 333);
            promptBox.TabIndex = 1;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(359, 16);
            imageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(40, 15);
            imageLabel.TabIndex = 2;
            imageLabel.Text = "Image";
            // 
            // saveImageBtn
            // 
            saveImageBtn.Location = new System.Drawing.Point(408, 10);
            saveImageBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            saveImageBtn.Name = "saveImageBtn";
            saveImageBtn.Size = new System.Drawing.Size(88, 27);
            saveImageBtn.TabIndex = 3;
            saveImageBtn.Text = "Save Image";
            saveImageBtn.UseVisualStyleBackColor = true;
            saveImageBtn.Visible = false;
            saveImageBtn.Click += saveImageBtn_Click;
            // 
            // numOfPicturesField
            // 
            numOfPicturesField.Location = new System.Drawing.Point(155, 415);
            numOfPicturesField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numOfPicturesField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numOfPicturesField.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOfPicturesField.Name = "numOfPicturesField";
            numOfPicturesField.Size = new System.Drawing.Size(140, 23);
            numOfPicturesField.TabIndex = 4;
            numOfPicturesField.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numOfPicturesField.ValueChanged += numOfPicturesField_ValueChanged;
            // 
            // numOfPicturesLabel
            // 
            numOfPicturesLabel.AutoSize = true;
            numOfPicturesLabel.Location = new System.Drawing.Point(29, 418);
            numOfPicturesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numOfPicturesLabel.Name = "numOfPicturesLabel";
            numOfPicturesLabel.Size = new System.Drawing.Size(113, 15);
            numOfPicturesLabel.TabIndex = 5;
            numOfPicturesLabel.Text = "Number of Pictures:";
            // 
            // imgResField
            // 
            imgResField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            imgResField.FormattingEnabled = true;
            imgResField.Items.AddRange(new object[] { "256x256", "512x512", "1024x1024" });
            imgResField.Location = new System.Drawing.Point(155, 384);
            imgResField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            imgResField.Name = "imgResField";
            imgResField.Size = new System.Drawing.Size(140, 23);
            imgResField.TabIndex = 6;
            imgResField.SelectedIndexChanged += imgResField_SelectedIndexChanged;
            // 
            // imgResLabel
            // 
            imgResLabel.AutoSize = true;
            imgResLabel.Location = new System.Drawing.Point(29, 388);
            imgResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imgResLabel.Name = "imgResLabel";
            imgResLabel.Size = new System.Drawing.Size(102, 15);
            imgResLabel.TabIndex = 7;
            imgResLabel.Text = "Image Resolution:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(29, 448);
            costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(34, 15);
            costLabel.TabIndex = 8;
            costLabel.Text = "Cost:";
            // 
            // requestCostText
            // 
            requestCostText.AutoSize = true;
            requestCostText.Location = new System.Drawing.Point(152, 448);
            requestCostText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            requestCostText.Name = "requestCostText";
            requestCostText.Size = new System.Drawing.Size(29, 15);
            requestCostText.TabIndex = 9;
            requestCostText.Text = "N/A";
            // 
            // generateBtn
            // 
            generateBtn.Location = new System.Drawing.Point(155, 479);
            generateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new System.Drawing.Size(88, 27);
            generateBtn.TabIndex = 10;
            generateBtn.Text = "Generate!";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_ClickAsync;
            // 
            // setAPIKeyBtn
            // 
            setAPIKeyBtn.Location = new System.Drawing.Point(61, 479);
            setAPIKeyBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            setAPIKeyBtn.Name = "setAPIKeyBtn";
            setAPIKeyBtn.Size = new System.Drawing.Size(88, 27);
            setAPIKeyBtn.TabIndex = 11;
            setAPIKeyBtn.Text = "Set API Key";
            setAPIKeyBtn.UseVisualStyleBackColor = true;
            setAPIKeyBtn.Click += setAPIKeyBtn_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(408, 43);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(450, 450);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // prevButton
            // 
            prevButton.Location = new System.Drawing.Point(360, 257);
            prevButton.Name = "prevButton";
            prevButton.Size = new System.Drawing.Size(42, 23);
            prevButton.TabIndex = 13;
            prevButton.Text = "<";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Visible = false;
            prevButton.Click += prevButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new System.Drawing.Point(864, 272);
            nextButton.Name = "nextButton";
            nextButton.Size = new System.Drawing.Size(42, 23);
            nextButton.TabIndex = 14;
            nextButton.Text = ">";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Visible = false;
            nextButton.Click += nextButton_Click;
            // 
            // DALLE2Frontend
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(929, 519);
            Controls.Add(nextButton);
            Controls.Add(prevButton);
            Controls.Add(pictureBox);
            Controls.Add(setAPIKeyBtn);
            Controls.Add(generateBtn);
            Controls.Add(requestCostText);
            Controls.Add(costLabel);
            Controls.Add(imgResLabel);
            Controls.Add(imgResField);
            Controls.Add(numOfPicturesLabel);
            Controls.Add(numOfPicturesField);
            Controls.Add(saveImageBtn);
            Controls.Add(imageLabel);
            Controls.Add(promptBox);
            Controls.Add(promptLabel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "DALLE2Frontend";
            Text = "DALLE2Frontend";
            Load += DALLE2Frontend_Load;
            ((System.ComponentModel.ISupportInitialize)numOfPicturesField).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox promptBox;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button saveImageBtn;
        private System.Windows.Forms.NumericUpDown numOfPicturesField;
        private System.Windows.Forms.Label numOfPicturesLabel;
        private System.Windows.Forms.ComboBox imgResField;
        private System.Windows.Forms.Label imgResLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label requestCostText;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button setAPIKeyBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
    }
}

