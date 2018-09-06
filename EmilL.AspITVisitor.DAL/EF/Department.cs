namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }

        public int AspITVisitDayId { get; set; }

        public int InquiryId { get; set; }

        public virtual AspITVisitDay AspITVisitDay { get; set; }

        public virtual Inquiry Inquiry { get; set; }
    }
}
