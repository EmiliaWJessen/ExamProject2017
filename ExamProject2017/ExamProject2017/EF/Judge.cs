namespace ExamProject2017.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Judge")]
    public partial class Judge
    {
        [Key]
        public int judge_No { get; set; }

        [Required]
        [StringLength(25)]
        public string judge_Name { get; set; }

        public int jGroup_No { get; set; }

        public virtual JudgesGroup JudgesGroup { get; set; }
    }
}
