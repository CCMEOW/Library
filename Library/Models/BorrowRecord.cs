namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BorrowRecord")]
    public partial class BorrowRecord
    {
        public int id { get; set; }

        public int readerId { get; set; }

        public int bookId { get; set; }

        [Column(TypeName = "date")]
        public DateTime borrowDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? returnDate { get; set; }

        public byte status { get; set; }

        public int? renew { get; set; }

        public virtual Book Book { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
