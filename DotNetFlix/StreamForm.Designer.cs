namespace DotNetFlix
{
    partial class StreamForm
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
            this.lblThankYou = new System.Windows.Forms.Label();
            this.lblChargeAmount = new System.Windows.Forms.Label();
            this.lblTheFollowingMovies = new System.Windows.Forms.Label();
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(94, 53);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(384, 24);
            this.lblThankYou.TabIndex = 0;
            this.lblThankYou.Text = "Thank you for choosing DotNETFLIX!";
            // 
            // lblChargeAmount
            // 
            this.lblChargeAmount.AutoSize = true;
            this.lblChargeAmount.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeAmount.Location = new System.Drawing.Point(67, 120);
            this.lblChargeAmount.Name = "lblChargeAmount";
            this.lblChargeAmount.Size = new System.Drawing.Size(424, 24);
            this.lblChargeAmount.TabIndex = 1;
            this.lblChargeAmount.Text = "Your Credit Card will be charged $00.00";
            // 
            // lblTheFollowingMovies
            // 
            this.lblTheFollowingMovies.AutoSize = true;
            this.lblTheFollowingMovies.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheFollowingMovies.Location = new System.Drawing.Point(54, 176);
            this.lblTheFollowingMovies.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblTheFollowingMovies.Name = "lblTheFollowingMovies";
            this.lblTheFollowingMovies.Size = new System.Drawing.Size(458, 48);
            this.lblTheFollowingMovies.TabIndex = 2;
            this.lblTheFollowingMovies.Text = "The following movie(s) will be available for online streaming during the next 48 " +
    "hours:";
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMovies.Location = new System.Drawing.Point(58, 251);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Size = new System.Drawing.Size(454, 235);
            this.flpMovies.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(151, 523);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(258, 56);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 628);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flpMovies);
            this.Controls.Add(this.lblTheFollowingMovies);
            this.Controls.Add(this.lblChargeAmount);
            this.Controls.Add(this.lblThankYou);
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.Text = "Grab the popcorn!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblChargeAmount;
        private System.Windows.Forms.Label lblTheFollowingMovies;
        private System.Windows.Forms.FlowLayoutPanel flpMovies;
        private System.Windows.Forms.Button btnOK;
    }
}