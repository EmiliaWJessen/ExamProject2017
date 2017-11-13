namespace ExamProject2017.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ranking")]
    public partial class Ranking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ranking()
        {
            Result = new HashSet<Result>();
        }

        [Key]
        public int ranking_No { get; set; }

        public int event_No { get; set; }

        public int sGroup_No { get; set; }

        public int jGroup_No { get; set; }

        public virtual Event Event { get; set; }

        public virtual JudgesGroup JudgesGroup { get; set; }

        public virtual StudentGroup StudentGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Result { get; set; }
    }
}
