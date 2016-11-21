/*
 * App: DotNETFlix 
 * Author: Lucas Berté Schoenardie
 * Student #: 200322197
 * App Creation Date: 11/01/2016
 * App Description: Online movie rental/purchase application
 */

namespace DotNetFlix.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movy()
        {
            Movie_Genres = new HashSet<Movie_Genres>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(120)]
        public string ImageString { get; set; }

        [Required]
        public string Synopsis { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string TrailerURL { get; set; }

        public bool? IsNewRelease { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie_Genres> Movie_Genres { get; set; }
    }
}
