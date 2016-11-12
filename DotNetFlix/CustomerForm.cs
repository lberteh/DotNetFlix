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
        public LoginForm previousForm;

        MoviesContext db = new MoviesContext();
        List<Movy> moviesList = new List<Movy>();
        public static Movy selectedMovie = new Movy();
        List<Genre> genres = new List<Genre>();
        Genre allGenres = new Genre() { GenreID = 0, Genre1 = "ALL GENRES" };
        Genre newReleases = new Genre() { GenreID = -1, Genre1 = "NEW RELEASES" };
        List<Genre> filteredGenres = new List<Genre>();
        BindingList<Movy> moviesBindingList = new BindingList<Movy>();
        private string _paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        private decimal totalCost;

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
            lstSelectedMovies.DataSource = moviesBindingList;
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
            //cBoxGenres.DataSource = filteredGenres;
            //cBoxGenres.DisplayMember = "Genre1";
            //cBoxGenres.ValueMember = "GenreID";
            getMovies(0);
            fillMoviesPanel();
        }

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

        private void getGenresList()
        {
            filteredGenres = (from m_g in db.Movie_Genres
                              join g in db.Genres on m_g.GenreID equals g.GenreID
                              select g).Distinct().ToList();           
            
        }

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

        private void Mouse_Leave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            //if(selectedMovie != (Movy)pb.Tag)
            //{
                pb.Size = new System.Drawing.Size(123, 182);
            //}            
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Size = new System.Drawing.Size(147, 218);
        }

        private void Movie_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            selectedMovie = (Movy)pb.Tag;
            lblTitle.Text = selectedMovie.Title;
            lblGenre.Text = getGenres();
            lblSynopsis.Text = selectedMovie.Synopsis;
            lblPrice.Text = selectedMovie.Price.ToString("C2");
        }

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

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(Movy m in moviesBindingList)
            {
                if(m.ID == selectedMovie.ID)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                moviesBindingList.Add(selectedMovie);
                TotalCost = TotalCost + selectedMovie.Price;
                btnCheckout.Enabled = true;
            }
            else
            {
                MessageBox.Show(selectedMovie.Title + " has already been added to the Cart!");
            }
            
        }

        private void btnWatchTrailer_Click(object sender, EventArgs e)
        {
            TrailerForm trailerForm = new TrailerForm();         

            // show next form
            trailerForm.Show();
        }

        private void RemoveMovie(object sender, EventArgs e)
        {
            Movy movie = (Movy)lstSelectedMovies.SelectedItem;
            moviesBindingList.Remove(movie);
            TotalCost = TotalCost - movie.Price;
            if (txtTotalCost.Text == "$0.00")
            {
                btnCheckout.Enabled = false;
            }
        }

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

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string str = "Star Wars the Force Awakens";
            string t = str + "   " + str.Length + "    " + str.Substring(0, 10);
            MessageBox.Show(t);
        }
    }
}
