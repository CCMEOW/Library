namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FineRecord")]
    public partial class FineRecord
    {
        public int id { get; set; }

        public int readerId { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal fine { get; set; }

        public int bookId { get; set; }

        [Column(TypeName = "date")]
        public DateTime fineDate { get; set; }

        [StringLength(100)]
        public string other { get; set; }

        public bool fromDeposit { get; set; }

        public virtual Book Book { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
