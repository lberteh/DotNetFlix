/*
 * App: DotNETFlix 
 * Author: Lucas Berté Schoenardie
 * Student #: 200322197
 * App Creation Date: 11/01/2016
 * App Description: Online movie rental/purchase application
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetFlix.Models;

namespace DotNetFlix
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            lblChargeAmount.Text = "Your Credit Card will be charged " + Program.totalCost;
            fillPanel();
        }

        // fills panel with all pertinent info regarding the purchase, including total cost and selected movies
        private void fillPanel()
        {
            foreach (Movy movie in Program.moviesBindingList)
            {
                Label lbl = new Label();
                lbl.Text = movie.Title;
                lbl.AutoSize = false;
                lbl.Size = new Size(444, 24);
                lbl.Font = new Font("Lucida Sans", 14);
                flpMovies.Controls.Add(lbl);
            }
        }

        // exists app
        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
