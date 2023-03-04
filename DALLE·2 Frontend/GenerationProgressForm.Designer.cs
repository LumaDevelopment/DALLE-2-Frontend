using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLE_2_Frontend
{
    partial class GenerationProgressForm
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
            progressBar = new System.Windows.Forms.ProgressBar();
            genImageLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(12, 35);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(260, 23);
            progressBar.TabIndex = 0;
            // 
            // genImageLabel
            // 
            genImageLabel.AutoSize = true;
            genImageLabel.Location = new System.Drawing.Point(12, 9);
            genImageLabel.Name = "genImageLabel";
            genImageLabel.Size = new System.Drawing.Size(110, 15);
            genImageLabel.TabIndex = 1;
            genImageLabel.Text = "Generating Image...";
            // 
            // GenerationProgressForm
            // 
            ClientSize = new System.Drawing.Size(284, 73);
            Controls.Add(genImageLabel);
            Controls.Add(progressBar);
            Name = "GenerationProgressForm";
            Text = "Generating Images...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label genImageLabel;
    }
}
