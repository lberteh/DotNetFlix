namespace DotNetFlix
{
    partial class CustomerForm
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
            this.cBoxGenres = new System.Windows.Forms.ComboBox();
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.btnWatchTrailer = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGenreLabel = new System.Windows.Forms.Label();
            this.lstSelectedMovies = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxGenres
            // 
            this.cBoxGenres.BackColor = System.Drawing.Color.White;
            this.cBoxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGenres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxGenres.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxGenres.FormattingEnabled = true;
            this.cBoxGenres.Location = new System.Drawing.Point(13, 13);
            this.cBoxGenres.MaxDropDownItems = 20;
            this.cBoxGenres.Name = "cBoxGenres";
            this.cBoxGenres.Size = new System.Drawing.Size(212, 26);
            this.cBoxGenres.TabIndex = 0;
            this.cBoxGenres.SelectedIndexChanged += new System.EventHandler(this.FilterMoviesByGenre);
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.Location = new System.Drawing.Point(13, 49);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Size = new System.Drawing.Size(726, 114);
            this.flpMovies.TabIndex = 1;
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.AutoSize = true;
            this.lblTitleLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLabel.Location = new System.Drawing.Point(6, 6);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(46, 18);
            this.lblTitleLabel.TabIndex = 2;
            this.lblTitleLabel.Text = "Title:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPriceLabel);
            this.panel1.Controls.Add(this.btnWatchTrailer);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblGenreLabel);
            this.panel1.Controls.Add(this.lblTitleLabel);
            this.panel1.Location = new System.Drawing.Point(6, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 169);
            this.panel1.TabIndex = 3;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(84, 27);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 18);
            this.lblGenre.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(84, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 18);
            this.lblTitle.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblSynopsis);
            this.panel2.Location = new System.Drawing.Point(9, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 120);
            this.panel2.TabIndex = 8;
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsis.Location = new System.Drawing.Point(11, 9);
            this.lblSynopsis.MaximumSize = new System.Drawing.Size(565, 0);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(64, 15);
            this.lblSynopsis.TabIndex = 8;
            this.lblSynopsis.Text = "Synopsis";
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceLabel.Location = new System.Drawing.Point(603, 6);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(50, 18);
            this.lblPriceLabel.TabIndex = 7;
            this.lblPriceLabel.Text = "Price:";
            // 
            // btnWatchTrailer
            // 
            this.btnWatchTrailer.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchTrailer.Location = new System.Drawing.Point(606, 49);
            this.btnWatchTrailer.Name = "btnWatchTrailer";
            this.btnWatchTrailer.Size = new System.Drawing.Size(108, 54);
            this.btnWatchTrailer.TabIndex = 6;
            this.btnWatchTrailer.Text = "Watch the Trailer";
            this.btnWatchTrailer.UseVisualStyleBackColor = true;
            this.btnWatchTrailer.Click += new System.EventHandler(this.btnWatchTrailer_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(606, 132);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(108, 37);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(659, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "$1.99";
            // 
            // lblGenreLabel
            // 
            this.lblGenreLabel.AutoSize = true;
            this.lblGenreLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreLabel.Location = new System.Drawing.Point(6, 27);
            this.lblGenreLabel.Name = "lblGenreLabel";
            this.lblGenreLabel.Size = new System.Drawing.Size(75, 18);
            this.lblGenreLabel.TabIndex = 3;
            this.lblGenreLabel.Text = "Genre(s):";
            // 
            // lstSelectedMovies
            // 
            this.lstSelectedMovies.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectedMovies.FormattingEnabled = true;
            this.lstSelectedMovies.ItemHeight = 16;
            this.lstSelectedMovies.Location = new System.Drawing.Point(746, 49);
            this.lstSelectedMovies.Name = "lstSelectedMovies";
            this.lstSelectedMovies.Size = new System.Drawing.Size(284, 388);
            this.lstSelectedMovies.TabIndex = 4;
            this.lstSelectedMovies.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatSelectedMoviesList);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Details";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(878, 457);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(152, 36);
            this.txtTotalCost.TabIndex = 6;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(878, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveMovie);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(745, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 27);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1042, 678);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSelectedMovies);
            this.Controls.Add(this.flpMovies);
            this.Controls.Add(this.cBoxGenres);
            this.Name = "CustomerForm";
            this.Text = ".NETFlix";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxGenres;
        private System.Windows.Forms.FlowLayoutPanel flpMovies;
        private System.Windows.Forms.Label lblTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGenreLabel;
        private System.Windows.Forms.ListBox lstSelectedMovies;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.Button btnWatchTrailer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
    }
}