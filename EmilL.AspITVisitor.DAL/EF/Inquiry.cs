namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inquiry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inquiry()
        {
            Departments = new HashSet<Department>();
            Guests = new HashSet<Guest>();
        }

        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string QuestionsString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
