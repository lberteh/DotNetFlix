namespace DotNetFlix
{
    partial class AddMovieForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.pBoxCover = new System.Windows.Forms.PictureBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtTrailer = new System.Windows.Forms.TextBox();
            this.lblTrailer = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNewRelease = new System.Windows.Forms.Label();
            this.checkBoxNewRelease = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(159, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(432, 30);
            this.txtTitle.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(182, 30);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "$1.99";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 83);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 22);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Location = new System.Drawing.Point(153, 501);
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(438, 114);
            this.txtSynopsis.TabIndex = 5;
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(27, 501);
            this.lblSynopsis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(93, 22);
            this.lblSynopsis.TabIndex = 4;
            this.lblSynopsis.Text = "Synopsis";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(27, 176);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(64, 22);
            this.lblCover.TabIndex = 6;
            this.lblCover.Text = "Cover";
            // 
            // pBoxCover
            // 
            this.pBoxCover.Location = new System.Drawing.Point(159, 176);
            this.pBoxCover.Name = "pBoxCover";
            this.pBoxCover.Size = new System.Drawing.Size(182, 273);
            this.pBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCover.TabIndex = 7;
            this.pBoxCover.TabStop = false;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(365, 83);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(146, 22);
            this.lblGenres.TabIndex = 8;
            this.lblGenres.Text = "Select Genre(s)";
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 22;
            this.listBoxGenres.Location = new System.Drawing.Point(369, 129);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGenres.Size = new System.Drawing.Size(222, 356);
            this.listBoxGenres.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(240, 455);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 30);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtTrailer
            // 
            this.txtTrailer.Location = new System.Drawing.Point(153, 635);
            this.txtTrailer.Name = "txtTrailer";
            this.txtTrailer.Size = new System.Drawing.Size(438, 30);
            this.txtTrailer.TabIndex = 13;
            // 
            // lblTrailer
            // 
            this.lblTrailer.AutoSize = true;
            this.lblTrailer.Location = new System.Drawing.Point(27, 638);
            this.lblTrailer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(112, 22);
            this.lblTrailer.TabIndex = 12;
            this.lblTrailer.Text = "Trailer URL";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 685);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 53);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(153, 685);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 53);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNewRelease
            // 
            this.lblNewRelease.AutoSize = true;
            this.lblNewRelease.Location = new System.Drawing.Point(27, 131);
            this.lblNewRelease.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewRelease.Name = "lblNewRelease";
            this.lblNewRelease.Size = new System.Drawing.Size(124, 22);
            this.lblNewRelease.TabIndex = 16;
            this.lblNewRelease.Text = "New Release";
            // 
            // checkBoxNewRelease
            // 
            this.checkBoxNewRelease.AutoSize = true;
            this.checkBoxNewRelease.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNewRelease.Location = new System.Drawing.Point(160, 133);
            this.checkBoxNewRelease.MinimumSize = new System.Drawing.Size(20, 20);
            this.checkBoxNewRelease.Name = "checkBoxNewRelease";
            this.checkBoxNewRelease.Size = new System.Drawing.Size(20, 20);
            this.checkBoxNewRelease.TabIndex = 17;
            this.checkBoxNewRelease.UseVisualStyleBackColor = true;
            this.checkBoxNewRelease.CheckedChanged += new System.EventHandler(this.checkBoxNewRelease_CheckedChanged);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 755);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxNewRelease);
            this.Controls.Add(this.lblNewRelease);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTrailer);
            this.Controls.Add(this.lblTrailer);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.listBoxGenres);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.pBoxCover);
            this.Controls.Add(this.lblCover);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.UploadMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.PictureBox pBoxCover;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtTrailer;
        private System.Windows.Forms.Label lblTrailer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNewRelease;
        private System.Windows.Forms.CheckBox checkBoxNewRelease;
    }
}

