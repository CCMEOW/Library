namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CancelRecord")]
    public partial class CancelRecord
    {
        public int id { get; set; }

        public int bookId { get; set; }

        [Column(TypeName = "date")]
        public DateTime cancelDate { get; set; }

        [StringLength(50)]
        public string reason { get; set; }

        [StringLength(50)]
        public string other { get; set; }

        public virtual Book Book { get; set; }
    }
}
