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
        public LoginForm previousForm;

        // create an instance of my database
        MoviesContext db = new MoviesContext();
        OpenFileDialog open = new OpenFileDialog();
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

        public void getGenres()
        {                   

            genresList = (from genre in db.Genres
                             select genre).ToList();

            listBoxGenres.DataSource = genresList;
            listBoxGenres.DisplayMember = "Genre1";
            listBoxGenres.ValueMember = "GenreID";
            listBoxGenres.ClearSelected();

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;

            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string imageName = System.IO.Path.GetFileName(open.FileName.Remove(open.FileName.Length - 3));
                    System.IO.File.Copy(open.FileName, paths + "\\Images\\" + RemoveSpecialCharacters(imageName.ToLower()) + DateTime.Now.ToString("ddMMyyyyhhmmssffff") + ".jpg");
                    MessageBox.Show("Successfully Uploaded");
                }
            }
        }
        public static string RemoveSpecialCharacters(string input)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.Replace(input, "");
        }



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

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MoviesContext db = new MoviesContext())
            {
                DotNetFlix.Models.test t = new test()
                {
                    name = txtTitle.Text
                };

                db.tests.Add(t);
                db.SaveChanges();

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MoviesContext db = new MoviesContext())
            {
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
                        string coverString = RemoveSpecialCharacters(txtTitle.Text.ToLower()) + DateTime.Now.ToString("ddMMyyyyhhmmssffff");                        
                        DotNetFlix.Models.Movy movie = new Movy()
                        {
                            Title = txtTitle.Text,
                            IsNewRelease = checkBoxNewRelease.Checked,
                            Price = decimal.Parse(txtPrice.Text.Substring(1)),
                            TrailerURL = txtTrailer.Text,
                            Synopsis = txtSynopsis.Text,
                            ImageString = coverString
                        };

                        pBoxCover.Image.Save(_paths + "\\Images\\" + coverString + ".jpg");
                        db.Movies.Add(movie);
                        db.SaveChanges();

                        Movy m = getInsertedMovie(coverString);

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

                                db.SaveChanges();

                                var count = (from m_g in db.Movie_Genres
                                             where m_g.MovieID == m.ID
                                             select m_g).Count();

                                if (count > 0)
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

        private Movy getInsertedMovie(string imageString)
        {           
            Movy m = (from movie in db.Movies
                        where movie.ImageString == imageString
                        select movie).FirstOrDefault();

            return m;           
        } 

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtSynopsis.Text = "";

            foreach (int i in listBoxGenres.SelectedIndices)
            {
                var item = (from genre in db.Genres
                            where genre.GenreID == (i + 1)
                            select genre).FirstOrDefault();

                Movy m = (from movie in db.Movies
                          where movie.ImageString == "thegodfather101120160200306001"
                          select movie).FirstOrDefault();

                txtSynopsis.Text = m.Title;

            }



            // var itemList = listBoxGenres.SelectedItems;



            //foreach (var item in listBoxGenres.SelectedItems)
            //{
            //    MessageBox.Show(item.ToString());
            //    // txtSynopsis.Text = txtSynopsis.Text + item.Genre1 + " ID = " + item.GenreID + ", ";
            //}

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        public void closeForm()
        {
            this.Close();
            previousForm.Show();
        }

        private void AddMovieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 
        }

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
