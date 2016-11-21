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
    public partial class OrderForm : Form
    {
        // instantiating objects and declaring/initializing variables
        MoviesContext db = new MoviesContext(); 
        public CustomerForm previousForm;
        int index = 0;
        List<Genre> genres = new List<Genre>();
        List<string> genresString = new List<string>();
        private string _paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        private decimal _cost = 0m;
        private decimal _DVDCost = 0m;


        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            getGenres();
            fillGetDVDPanel();
            fillSelectedMoviesPanel();
            setCost();
            fillOrderTotals();
        }

        // displays checkboxes with all movies in the cart to select buy dvd option
        public void fillGetDVDPanel()
        {
            foreach (Movy movie in Program.moviesBindingList)
            {
                CheckBox cb = new CheckBox();
                cb.Text = movie.Title;
                cb.AutoSize = false;
                cb.Size = new Size(340, 19);
                cb.CheckedChanged += new EventHandler(AddDVDCost);
                flpSelectedMovies.Controls.Add(cb);
                
            }
        }

        // adds $10.00 for each movie checked (dvd cost)
        private void AddDVDCost(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if(cb.Checked)
            {
                _DVDCost = _DVDCost + 10.00m;
            }
            else
            {
                _DVDCost = _DVDCost - 10.00m;
            }
            fillOrderTotals();
        }

        // displays info from first selected movie in the list
        public void fillSelectedMoviesPanel()
        {
            lblTitle.Text = Program.moviesBindingList[0].Title;
            lblGenres.Text = this.genresString[0];
            pBoxCover.Image = new Bitmap(@_paths + "\\Images\\" + Program.moviesBindingList[0].ImageString + ".jpg");
        }

        // gets displayed movie genres
        private void getGenres()
        {
            string temp = "";

            foreach(Movy m in Program.moviesBindingList)
            {
                genres = (from g in db.Genres
                          join m_g in db.Movie_Genres on g.GenreID equals m_g.GenreID
                          where m_g.MovieID == m.ID
                          select g).ToList();

                foreach(Genre g in genres)
                {
                    temp = temp + g.Genre1 + ", ";
                }

                temp = temp.Remove(temp.Length - 2);

                this.genresString.Add(temp);

                temp = "";
            }                    
        }
        
        // displays next movie in the list
        private void GoToNextMovie(object sender, EventArgs e)
        {
            if (index < Program.moviesBindingList.Count - 1)
            {
                index += 1;                
                lblTitle.Text = Program.moviesBindingList[index].Title;
                lblGenres.Text = this.genresString[index];
                pBoxCover.Image = new Bitmap(@_paths + "\\Images\\" + Program.moviesBindingList[index].ImageString + ".jpg");
            }
            if (index == Program.moviesBindingList.Count - 1)
            {
                btnNextMovie.Enabled = false;
            }
            if(btnPreviousMovie.Enabled == false)
            {
                btnPreviousMovie.Enabled = true;
            }
        }

        // displays previous movie in the list
        private void GoToPreviousMovie(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index -= 1;
                lblTitle.Text = Program.moviesBindingList[index].Title;
                lblGenres.Text = this.genresString[index];
                pBoxCover.Image = new Bitmap(@_paths + "\\Images\\" + Program.moviesBindingList[index].ImageString + ".jpg");
            }
            if (index == 0)
            {
                btnPreviousMovie.Enabled = false;
            }
            if (btnNextMovie.Enabled == false)
            {
                btnNextMovie.Enabled = true;
            }
        }

        // fills order panel with all costs, totals, subtotals and tax info
        private void fillOrderTotals()
        {
            txtCost.Text = _cost.ToString("C2");
            txtDVDCost.Text = _DVDCost.ToString("C2");
            txtSubTotal.Text = (_cost + _DVDCost).ToString("C2");
            txtTax.Text = ((_cost + _DVDCost) * 0.13m).ToString("C2");
            txtGrandTotal.Text = ((_cost + _DVDCost) + ((_cost + _DVDCost) * 0.13m)).ToString("C2");
            Program.totalCost = txtGrandTotal.Text;
        }

        // sums cost of all selected movies and sets _cost variable
        private void setCost()
        {
            foreach(Movy m in Program.moviesBindingList)
            {
                _cost = _cost + m.Price;
            }            
        }

        // goes to next form
        private void btnStream_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();            

            // hide this form
            this.Hide();

            // show next form
            streamForm.Show();
        }

        // cancels purchase clearing all selections and goes back to previous form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Cancel?? All your selections will be lost.",
                                     "Confirm Cancel!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                CustomerForm customerForm = new CustomerForm();
                Program.moviesBindingList.Clear();
                this.Close();

                previousForm.Close();

                customerForm.Show();
            }
            else
            {
                
            }
          
        }

        // goes back to previous form keeping all selections
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }

    
}
