namespace DotNetFlix.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test")]
    public partial class test
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string lastName { get; set; }

        public string imgString { get; set; }
    }
}
