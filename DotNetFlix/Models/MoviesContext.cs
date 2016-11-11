namespace DotNetFlix.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MoviesContext : DbContext
    {
        public MoviesContext()
            : base("name=MoviesConnection")
        {
        }

        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie_Genres> Movie_Genres { get; set; }
        public virtual DbSet<Movy> Movies { get; set; }
        public virtual DbSet<test> tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Movie_Genres)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Movie_Genres)
                .WithRequired(e => e.Movy)
                .HasForeignKey(e => e.MovieID)
                .WillCascadeOnDelete(false);
        }
    }
}
