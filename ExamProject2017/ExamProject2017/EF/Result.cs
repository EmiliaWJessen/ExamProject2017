namespace ExamProject2017.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        [Key]
        public int result_No { get; set; }

        public int ranking_No { get; set; }

        public int question_No { get; set; }

        public int result_Points { get; set; }

        public virtual Question Question { get; set; }

        public virtual Ranking Ranking { get; set; }
    }
}
