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

namespace DotNetFlix
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // goes to add movie form
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            addMovieForm.previousForm = this;

            // hide this form
            this.Hide();

            // show next form
            addMovieForm.Show();
        }

        // goes to customer form
        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.previousForm = this;

            // hide this form
            this.Hide();

            // show next form
            customerForm.Show();
        }
     
    }
}
