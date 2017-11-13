namespace ExamProject2017.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JudgesGroup")]
    public partial class JudgesGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JudgesGroup()
        {
            Judge = new HashSet<Judge>();
            Ranking = new HashSet<Ranking>();
        }

        [Key]
        public int jGroup_No { get; set; }

        [Required]
        [StringLength(20)]
        public string jGroup_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Judge> Judge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ranking> Ranking { get; set; }
    }
}
