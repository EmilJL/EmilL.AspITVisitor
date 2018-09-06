namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questionnaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questionnaire()
        {
            FreeAnswerQuestions = new HashSet<FreeAnswerQuestion>();
            Guests = new HashSet<Guest>();
            MultipleChoiseQuestions = new HashSet<MultipleChoiseQuestion>();
        }

        public int Id { get; set; }

        public bool Active { get; set; }

        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FreeAnswerQuestion> FreeAnswerQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultipleChoiseQuestion> MultipleChoiseQuestions { get; set; }
    }
}
