namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MultipleChoiseAnswer
    {
        public int Id { get; set; }

        public int PossibleAnswerId { get; set; }

        public int GuestId { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer { get; set; }

        [Required]
        [StringLength(100)]
        public string Question { get; set; }

        public virtual Guest Guest { get; set; }

        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}
