namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            BorrowRecord = new HashSet<BorrowRecord>();
            CancelRecord = new HashSet<CancelRecord>();
            FineRecord = new HashSet<FineRecord>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string publisher { get; set; }

        public int? subsection { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(50)]
        public string publishLocation { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? price { get; set; }

        public int? page { get; set; }

        [Column(TypeName = "date")]
        public DateTime? publishDate { get; set; }

        public int? size { get; set; }

        [StringLength(50)]
        public string language { get; set; }

        public bool? CD { get; set; }

        public int? edition { get; set; }

        public byte? surface { get; set; }

        [StringLength(50)]
        public string series { get; set; }

        public int? totalNum { get; set; }

        public int? leftNum { get; set; }

        [StringLength(50)]
        public string rank { get; set; }

        public int? classNum { get; set; }

        [StringLength(50)]
        public string className { get; set; }

        public int? titleNum { get; set; }

        [StringLength(50)]
        public string biblio { get; set; }

        [StringLength(50)]
        public string place { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        public string summary { get; set; }

        public string other { get; set; }

        public byte? status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? addDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowRecord> BorrowRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CancelRecord> CancelRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FineRecord> FineRecord { get; set; }
    }
}
