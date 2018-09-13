namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guest()
        {
            FreeAnswers = new HashSet<FreeAnswer>();
            MultipleChoiseAnswers = new HashSet<MultipleChoiseAnswer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string Commune { get; set; }

        public int Age { get; set; }

        public bool WishesToBeStudent { get; set; }

        public int AspITVisitDayId { get; set; }


        public int QuestionnaireId { get; set; }

        public virtual AspITVisitDay AspITVisitDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FreeAnswer> FreeAnswers { get; set; }


        public virtual Questionnaire Questionnaire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiseAnswer> MultipleChoiseAnswers { get; set; }
    }
}
