namespace DotNetFlix
{
    partial class TrailerForm
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
            this.webBrowserTrailer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserTrailer
            // 
            this.webBrowserTrailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTrailer.Location = new System.Drawing.Point(0, 0);
            this.webBrowserTrailer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTrailer.Name = "webBrowserTrailer";
            this.webBrowserTrailer.Size = new System.Drawing.Size(899, 592);
            this.webBrowserTrailer.TabIndex = 0;
            // 
            // TrailerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 592);
            this.Controls.Add(this.webBrowserTrailer);
            this.Name = "TrailerForm";
            this.Text = "TrailerForm";
            this.Load += new System.EventHandler(this.TrailerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserTrailer;
    }
}