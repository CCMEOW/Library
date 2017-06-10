namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reader")]
    public partial class Reader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reader()
        {
            BorrowRecord = new HashSet<BorrowRecord>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(10)]
        public string sex { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal deposit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deadline { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        public byte? status { get; set; }

        public string other { get; set; }

        public int leftBook { get; set; }

        [Required]
        [StringLength(50)]
        public string idCard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowRecord> BorrowRecord { get; set; }

        public virtual ChargeRecord ChargeRecord { get; set; }

        public virtual FineRecord FineRecord { get; set; }
    }
}
