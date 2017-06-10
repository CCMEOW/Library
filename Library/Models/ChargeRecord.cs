namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChargeRecord")]
    public partial class ChargeRecord
    {
        public int id { get; set; }

        public int readerId { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(50)]
        public string _operator { get; set; }

        [Column(TypeName = "date")]
        public DateTime chargeDate { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal money { get; set; }

        [StringLength(100)]
        public string other { get; set; }

        public bool putin { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
