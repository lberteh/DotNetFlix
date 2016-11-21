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
    public partial class CustomerForm : Form
    {
        public LoginForm previousForm; // references previous form
        MoviesContext db = new MoviesContext(); // instantiate my db context
        List<Movy> moviesList = new List<Movy>(); // instantiate a movies List 
        public static Movy selectedMovie = new Movy(); // holds the movie selected by the user
        List<Genre> genres = new List<Genre>(); // instantiate a list of genres
        // instantiate new genres properties to use in dropdown filter 
        Genre allGenres = new Genre() { GenreID = 0, Genre1 = "ALL GENRES" }; 
        Genre newReleases = new Genre() { GenreID = -1, Genre1 = "NEW RELEASES" };
        List<Genre> filteredGenres = new List<Genre>(); // holds the genres for selected movie      
        private string _paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)); // application path
        private decimal totalCost; // total cost of selected movies

        // total cost property
        public decimal TotalCost
        {
            get { return totalCost; }
            set
            {
                totalCost = value;
                txtTotalCost.Text = totalCost.ToString("C2");
            }
        }

        public CustomerForm()
        {
            InitializeComponent();
            lstSelectedMovies.DataSource = Program.moviesBindingList;
            lstSelectedMovies.DisplayMember = "Title";
            lstSelectedMovies.ValueMember = "ID";
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {            
            getGenresList();
            filteredGenres.Insert(0, newReleases);
            filteredGenres.Insert(0, allGenres);
            fillCombobox();
            cBoxGenres.SelectedIndex = 0;
            getMovies(0);
            fillMoviesPanel();
        }

        // fill combobox with genres from movies that are in db
        private void fillCombobox()
        {
            // Bind combobox to dictionary
            Dictionary<int, string> items = new Dictionary<int, string>();
            foreach(Genre g in filteredGenres)
            {
                items.Add(g.GenreID, g.Genre1);
            }
            cBoxGenres.DataSource = new BindingSource(items, null);
            cBoxGenres.DisplayMember = "Value";
            cBoxGenres.ValueMember = "Key";
        }

        // gets all genres within existing movies in db, no repeat
        private void getGenresList()
        {
            filteredGenres = (from m_g in db.Movie_Genres
                              join g in db.Genres on m_g.GenreID equals g.GenreID
                              select g).Distinct().ToList();           
            
        }

        // displays movies according to selected genre 
        public void getMovies(int id)
        {
            if (id == -1)
            {
                moviesList = (from movies in db.Movies
                              where movies.IsNewRelease == true
                              select movies).ToList();
            }
            else if (id == 0)
            {
                moviesList = (from movies in db.Movies                              
                              select movies).ToList();
            }
            else
            {
                moviesList = (from movies in db.Movies
                              join m_g in db.Movie_Genres on movies.ID equals m_g.MovieID
                              where m_g.GenreID == id
                              select movies).ToList();
            }
            
        }

        // fills the panel with filtered movies from getMovies(int id);
        public void fillMoviesPanel()
        {
            flpMovies.Controls.Clear();
            foreach (Movy t in moviesList)
            {
                PictureBox pb = new PictureBox();
                pb.Image = new Bitmap(@_paths + "\\Images\\" + t.ImageString + ".jpg");
                pb.Size = new System.Drawing.Size(123, 182);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Tag = t;
         
                flpMovies.Controls.Add(pb);
                pb.Click += new EventHandler(Movie_Click);
                pb.MouseEnter += new EventHandler(Mouse_Enter);
                pb.MouseLeave += new EventHandler(Mouse_Leave);
            }
        }

        // picture box goes back to regular size when mouse leaves
        private void Mouse_Leave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            //if(selectedMovie != (Movy)pb.Tag)
            //{
                pb.Size = new System.Drawing.Size(123, 182);
            //}            
        }

        // makes movie cover big when mouse enters the picture box
        private void Mouse_Enter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Size = new System.Drawing.Size(147, 218);
        }

        // selects movie and displays movie info
        private void Movie_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            selectedMovie = (Movy)pb.Tag;
            lblTitle.Text = selectedMovie.Title;
            lblGenre.Text = getGenres();
            lblSynopsis.Text = selectedMovie.Synopsis;
            lblPrice.Text = selectedMovie.Price.ToString("C2");
        }

        // gets all genres from clicked movie
        private string getGenres()
        {
            genres = (from g in db.Genres
                      join m_g in db.Movie_Genres on g.GenreID equals m_g.GenreID
                      where m_g.MovieID == selectedMovie.ID
                      select g).ToList();
            
            string genresString = "";
            
            foreach (var g in genres)
            {
                genresString = genresString + g.Genre1 + ", ";
            }

            return genresString.Remove(genresString.Length - 2); 
        }

        // formats string to display movie title and price in the selected movies listbox
        private void FormatSelectedMoviesList(object sender, ListControlConvertEventArgs e)
        {
            string currentTitle = ((Movy)e.ListItem).Title;
            if (currentTitle.Length > 27)
            {
                currentTitle = currentTitle.Substring(0, 24) + "...";
            }
            string currentTitlePadded = currentTitle.PadRight(29);
            string currentPrice = ((Movy)e.ListItem).Price.ToString("C2");            
            

            e.Value = currentTitlePadded + currentPrice;
        }

        // adds movie to cart
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(Movy m in Program.moviesBindingList)
            {
                if(m.ID == selectedMovie.ID)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Program.moviesBindingList.Add(selectedMovie);
                TotalCost = TotalCost + selectedMovie.Price;
                btnCheckout.Enabled = true;
            }
            else
            {
                MessageBox.Show(selectedMovie.Title + " has already been added to the Cart!");
            }
            
        }

        // opens a form with youtube movie trailer
        private void btnWatchTrailer_Click(object sender, EventArgs e)
        {
            TrailerForm trailerForm = new TrailerForm();         

            // show next form
            trailerForm.Show();
        }

        // removes selected movie from cart
        private void RemoveMovie(object sender, EventArgs e)
        {
            Movy movie = (Movy)lstSelectedMovies.SelectedItem;
            Program.moviesBindingList.Remove(movie);
            TotalCost = TotalCost - movie.Price;
            if (txtTotalCost.Text == "$0.00")
            {
                btnCheckout.Enabled = false;
            }
        }

        // filter movies to be displayed by the selected genre in the combobox
        private void FilterMoviesByGenre(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string value = ((KeyValuePair<int, string>)cBoxGenres.SelectedItem).Value;
            int key = ((KeyValuePair<int, string>)cBoxGenres.SelectedItem).Key;
            // MessageBox.Show(value + "   " + key);
            moviesList.Clear();
            getMovies(key);
            fillMoviesPanel();
        }

        // closes and goes back to previous form
        private void CloseForm(object sender, EventArgs e)
        {
            Program.moviesBindingList.Clear();
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        // hides form and goes to next form
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;

            // hide this form
            this.Hide();

            // show next form
            orderForm.Show();
        }
    }
}
