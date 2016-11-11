namespace DotNetFlix.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie_Genres
    {
        public int Movie_GenresID { get; set; }

        public int MovieID { get; set; }

        public int GenreID { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Movy Movy { get; set; }
    }
}
