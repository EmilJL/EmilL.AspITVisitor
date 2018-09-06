namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FreeAnswerQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FreeAnswerQuestion()
        {
            FreeAnswers = new HashSet<FreeAnswer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Question { get; set; }

        public int QuestionnaireId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FreeAnswer> FreeAnswers { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }
    }
}
