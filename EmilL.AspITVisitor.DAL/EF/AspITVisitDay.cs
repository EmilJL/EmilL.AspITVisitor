namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspITVisitDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspITVisitDay()
        {
            Guests = new HashSet<Guest>();
            Inquiries = new HashSet<Inquiry>();
        }

        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public int AdminId { get; set; }

        public int DepartmentId { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inquiry> Inquiries { get; set; }
    }
}
