using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFlix
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            addMovieForm.previousForm = this;

            // hide this form
            this.Hide();

            // show next form
            addMovieForm.Show();
        }
    }
}
