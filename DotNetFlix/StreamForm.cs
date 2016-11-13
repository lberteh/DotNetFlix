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

        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
