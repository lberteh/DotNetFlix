namespace DotNetFlix
{
    partial class OrderForm
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
            this.menuStripOrderForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxOrderDVD = new System.Windows.Forms.GroupBox();
            this.flpSelectedMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtDVDCost = new System.Windows.Forms.TextBox();
            this.lblDvDCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.gBoxSelections = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreviousMovie = new System.Windows.Forms.Button();
            this.btnNextMovie = new System.Windows.Forms.Button();
            this.pBoxCover = new System.Windows.Forms.PictureBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenreLabel = new System.Windows.Forms.Label();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.menuStripOrderForm.SuspendLayout();
            this.gBoxOrderDVD.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.gBoxSelections.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripOrderForm
            // 
            this.menuStripOrderForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripOrderForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripOrderForm.Name = "menuStripOrderForm";
            this.menuStripOrderForm.Size = new System.Drawing.Size(1294, 24);
            this.menuStripOrderForm.TabIndex = 0;
            this.menuStripOrderForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "&Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "&Cancel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // gBoxOrderDVD
            // 
            this.gBoxOrderDVD.Controls.Add(this.flpSelectedMovies);
            this.gBoxOrderDVD.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxOrderDVD.Location = new System.Drawing.Point(22, 38);
            this.gBoxOrderDVD.Name = "gBoxOrderDVD";
            this.gBoxOrderDVD.Size = new System.Drawing.Size(397, 565);
            this.gBoxOrderDVD.TabIndex = 1;
            this.gBoxOrderDVD.TabStop = false;
            this.gBoxOrderDVD.Text = "Get the DVD for only $10.00 each";
            // 
            // flpSelectedMovies
            // 
            this.flpSelectedMovies.AutoScroll = true;
            this.flpSelectedMovies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSelectedMovies.Location = new System.Drawing.Point(26, 31);
            this.flpSelectedMovies.Name = "flpSelectedMovies";
            this.flpSelectedMovies.Size = new System.Drawing.Size(370, 534);
            this.flpSelectedMovies.TabIndex = 0;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.btnStream);
            this.groupBoxOrder.Controls.Add(this.btnCancel);
            this.groupBoxOrder.Controls.Add(this.btnBack);
            this.groupBoxOrder.Controls.Add(this.txtGrandTotal);
            this.groupBoxOrder.Controls.Add(this.lblGrandTotal);
            this.groupBoxOrder.Controls.Add(this.txtTax);
            this.groupBoxOrder.Controls.Add(this.lblTax);
            this.groupBoxOrder.Controls.Add(this.txtSubTotal);
            this.groupBoxOrder.Controls.Add(this.lblSubTotal);
            this.groupBoxOrder.Controls.Add(this.txtDVDCost);
            this.groupBoxOrder.Controls.Add(this.lblDvDCost);
            this.groupBoxOrder.Controls.Add(this.txtCost);
            this.groupBoxOrder.Controls.Add(this.lblCost);
            this.groupBoxOrder.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrder.Location = new System.Drawing.Point(940, 38);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(334, 565);
            this.groupBoxOrder.TabIndex = 2;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Your Order";
            // 
            // btnStream
            // 
            this.btnStream.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStream.Location = new System.Drawing.Point(144, 481);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(184, 78);
            this.btnStream.TabIndex = 12;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(6, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(6, 523);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.White;
            this.txtGrandTotal.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(170, 338);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(135, 30);
            this.txtGrandTotal.TabIndex = 9;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(32, 341);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(120, 22);
            this.lblGrandTotal.TabIndex = 8;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.White;
            this.txtTax.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(170, 284);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(135, 30);
            this.txtTax.TabIndex = 7;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(32, 287);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(98, 22);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax (13%)";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(170, 229);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(135, 30);
            this.txtSubTotal.TabIndex = 5;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(32, 232);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(92, 22);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtDVDCost
            // 
            this.txtDVDCost.BackColor = System.Drawing.Color.White;
            this.txtDVDCost.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVDCost.Location = new System.Drawing.Point(170, 159);
            this.txtDVDCost.Name = "txtDVDCost";
            this.txtDVDCost.ReadOnly = true;
            this.txtDVDCost.Size = new System.Drawing.Size(135, 30);
            this.txtDVDCost.TabIndex = 3;
            // 
            // lblDvDCost
            // 
            this.lblDvDCost.AutoSize = true;
            this.lblDvDCost.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvDCost.Location = new System.Drawing.Point(32, 162);
            this.lblDvDCost.Name = "lblDvDCost";
            this.lblDvDCost.Size = new System.Drawing.Size(100, 22);
            this.lblDvDCost.TabIndex = 2;
            this.lblDvDCost.Text = "DVD Cost";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(170, 104);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(135, 30);
            this.txtCost.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(32, 107);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(53, 22);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost";
            // 
            // gBoxSelections
            // 
            this.gBoxSelections.Controls.Add(this.panel1);
            this.gBoxSelections.Controls.Add(this.lblGenres);
            this.gBoxSelections.Controls.Add(this.lblTitle);
            this.gBoxSelections.Controls.Add(this.lblGenreLabel);
            this.gBoxSelections.Controls.Add(this.lblTitleLabel);
            this.gBoxSelections.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSelections.Location = new System.Drawing.Point(440, 38);
            this.gBoxSelections.Name = "gBoxSelections";
            this.gBoxSelections.Size = new System.Drawing.Size(479, 565);
            this.gBoxSelections.TabIndex = 2;
            this.gBoxSelections.TabStop = false;
            this.gBoxSelections.Text = "Your Selection(s)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnPreviousMovie);
            this.panel1.Controls.Add(this.btnNextMovie);
            this.panel1.Controls.Add(this.pBoxCover);
            this.panel1.Location = new System.Drawing.Point(9, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 485);
            this.panel1.TabIndex = 14;
            // 
            // btnPreviousMovie
            // 
            this.btnPreviousMovie.BackColor = System.Drawing.Color.White;
            this.btnPreviousMovie.Enabled = false;
            this.btnPreviousMovie.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMovie.Location = new System.Drawing.Point(11, 213);
            this.btnPreviousMovie.Name = "btnPreviousMovie";
            this.btnPreviousMovie.Size = new System.Drawing.Size(43, 59);
            this.btnPreviousMovie.TabIndex = 18;
            this.btnPreviousMovie.Text = "<";
            this.btnPreviousMovie.UseVisualStyleBackColor = false;
            this.btnPreviousMovie.Click += new System.EventHandler(this.GoToPreviousMovie);
            // 
            // btnNextMovie
            // 
            this.btnNextMovie.BackColor = System.Drawing.Color.White;
            this.btnNextMovie.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMovie.Location = new System.Drawing.Point(410, 213);
            this.btnNextMovie.Name = "btnNextMovie";
            this.btnNextMovie.Size = new System.Drawing.Size(43, 59);
            this.btnNextMovie.TabIndex = 17;
            this.btnNextMovie.Text = ">";
            this.btnNextMovie.UseVisualStyleBackColor = false;
            this.btnNextMovie.Click += new System.EventHandler(this.GoToNextMovie);
            // 
            // pBoxCover
            // 
            this.pBoxCover.Location = new System.Drawing.Point(63, 0);
            this.pBoxCover.Name = "pBoxCover";
            this.pBoxCover.Size = new System.Drawing.Size(339, 485);
            this.pBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCover.TabIndex = 14;
            this.pBoxCover.TabStop = false;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.Location = new System.Drawing.Point(87, 47);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(46, 18);
            this.lblGenres.TabIndex = 13;
            this.lblGenres.Text = "Title:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 18);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title:";
            // 
            // lblGenreLabel
            // 
            this.lblGenreLabel.AutoSize = true;
            this.lblGenreLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreLabel.Location = new System.Drawing.Point(6, 47);
            this.lblGenreLabel.Name = "lblGenreLabel";
            this.lblGenreLabel.Size = new System.Drawing.Size(75, 18);
            this.lblGenreLabel.TabIndex = 10;
            this.lblGenreLabel.Text = "Genre(s):";
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.AutoSize = true;
            this.lblTitleLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLabel.Location = new System.Drawing.Point(6, 22);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(46, 18);
            this.lblTitleLabel.TabIndex = 9;
            this.lblTitleLabel.Text = "Title:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 624);
            this.ControlBox = false;
            this.Controls.Add(this.gBoxSelections);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.gBoxOrderDVD);
            this.Controls.Add(this.menuStripOrderForm);
            this.MainMenuStrip = this.menuStripOrderForm;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStripOrderForm.ResumeLayout(false);
            this.menuStripOrderForm.PerformLayout();
            this.gBoxOrderDVD.ResumeLayout(false);
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.gBoxSelections.ResumeLayout(false);
            this.gBoxSelections.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOrderForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxOrderDVD;
        private System.Windows.Forms.FlowLayoutPanel flpSelectedMovies;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtDVDCost;
        private System.Windows.Forms.Label lblDvDCost;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gBoxSelections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxCover;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenreLabel;
        private System.Windows.Forms.Label lblTitleLabel;
        private System.Windows.Forms.Button btnPreviousMovie;
        private System.Windows.Forms.Button btnNextMovie;
    }
}