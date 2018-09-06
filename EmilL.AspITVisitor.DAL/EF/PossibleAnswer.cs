namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PossibleAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PossibleAnswer()
        {
            MultipleChoiseAnswers = new HashSet<MultipleChoiseAnswer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer { get; set; }

        public int MultipleChoiseQuestionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiseAnswer> MultipleChoiseAnswers { get; set; }

        public virtual MultipleChoiseQuestion MultipleChoiseQuestion { get; set; }
    }
}
