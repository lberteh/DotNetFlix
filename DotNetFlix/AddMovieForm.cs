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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetFlix.Models;

namespace DotNetFlix
{
    public partial class AddMovieForm : Form
    {
        public LoginForm previousForm; // reference to previous form 

        // objects
        MoviesContext db = new MoviesContext();
        OpenFileDialog open = new OpenFileDialog();

        // path used to upload and get images
        private string _paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        List<Genre> genresList;

        public AddMovieForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        private void UploadMovie_Load(object sender, EventArgs e)
        {           
            getGenres();
        }

        // gets a list of movie genres from the db
        public void getGenres()
        {                 
            genresList = (from genre in db.Genres
                             select genre).ToList();

            listBoxGenres.DataSource = genresList;
            listBoxGenres.DisplayMember = "Genre1";
            listBoxGenres.ValueMember = "GenreID";
            listBoxGenres.ClearSelected();

        }

        // removes special characters and spaces (used to name the image before uploading)
        public static string RemoveSpecialCharacters(string input)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.Replace(input, "");
        }


        // browse for a jpg image and displays selected image in picture box
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    try
                    {
                        pBoxCover.Image = new Bitmap(open.FileName);                       
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image" + ex.Message);
                    }
                }
            }

        }

        // saves movie to database
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MoviesContext db = new MoviesContext())
            {
                // I did not add validation for every field... 
                decimal d;
                if (string.IsNullOrWhiteSpace(txtTitle.Text)) 
                {
                    MessageBox.Show("Title Field is required");                    
                }
                else if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Price Field is required");
                }                
                else if(!decimal.TryParse(txtPrice.Text.Substring(1), out d)) // If it's not a decimal, return false
                {
                    MessageBox.Show("InvalidPrice");
                }                
                else
                {
                    try
                    {
                        // sets the name of the image file using movie title without special characters and spaces + timestamp
                        string coverString = RemoveSpecialCharacters(txtTitle.Text.ToLower()) + DateTime.Now.ToString("ddMMyyyyhhmmssffff");                        
                        DotNetFlix.Models.Movy movie = new Movy() // creates a new movie object 
                        {
                            Title = txtTitle.Text,
                            IsNewRelease = checkBoxNewRelease.Checked,
                            Price = decimal.Parse(txtPrice.Text.Substring(1)),
                            TrailerURL = txtTrailer.Text,
                            Synopsis = txtSynopsis.Text,
                            ImageString = coverString
                        };
                        // save movie to db and upload image to images folder
                        pBoxCover.Image.Save(_paths + "\\Images\\" + coverString + ".jpg");
                        db.Movies.Add(movie);
                        db.SaveChanges(); 

                        Movy m = getInsertedMovie(coverString); // gets movie that was just saved to db using the imageName as filter

                        if (m.ImageString == coverString)
                        {
                            try
                            {                              
                                foreach (int i in listBoxGenres.SelectedIndices)
                                {
                                    var item = (from genre in db.Genres
                                                where genre.GenreID == (i + 1)
                                                select genre).FirstOrDefault();

                                    int genreID = i + 1;

                                    Movie_Genres movie_genre = new Movie_Genres()
                                    {
                                        MovieID = m.ID,
                                        GenreID = genreID
                                    };

                                    db.Movie_Genres.Add(movie_genre);
                                }

                                db.SaveChanges(); // saves movie genres to movie_genres table 

                                var count = (from m_g in db.Movie_Genres
                                             where m_g.MovieID == m.ID
                                             select m_g).Count();

                                if (count > 0) // if count is greater than 0, it means it worked, so clear form and display success message
                                {
                                    MessageBox.Show(m.Title + " successfully added!");
                                    txtTitle.Text = "";
                                    txtPrice.Text = "$1.99";
                                    txtSynopsis.Text = "";
                                    txtTrailer.Text = "";
                                    pBoxCover.Image = null;
                                    checkBoxNewRelease.Checked = false;
                                    listBoxGenres.ClearSelected();
                                }
                                else
                                {
                                    db.Movies.Remove(m);
                                    MessageBox.Show("Something went wrong, could not add movie!");
                                }
                            }
                            catch(Exception exception)
                            {
                                MessageBox.Show(exception.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Something went wrong, could not add movie!");
                        }
                        
                    }
                    catch(Exception exception)
                    {                        
                        MessageBox.Show(exception.Message);
                    }                  
                }                           
            }
        }

        // returns the movie that was just inserted in the database 
        private Movy getInsertedMovie(string imageString)
        {           
            Movy m = (from movie in db.Movies
                        where movie.ImageString == imageString
                        select movie).FirstOrDefault();

            return m;           
        } 

        // closes and returns to previous form
        private void btnBack_Click(object sender, EventArgs e)
        {           
            this.Close();
            previousForm.Show();
        }

        // adds $2.00 to price if New Release checkBox is checked
        private void checkBoxNewRelease_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNewRelease.Checked)
            {
                txtPrice.Text = 3.99.ToString("C2");
            } 
            else
            {
                txtPrice.Text = 1.99.ToString("C2");
            }
        }
    }
}
