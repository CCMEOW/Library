namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catogary")]
    public partial class Catogary
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string serialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
