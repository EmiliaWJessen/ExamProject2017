namespace ExamProject2017.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int student_No { get; set; }

        [Required]
        [StringLength(25)]
        public string student_Name { get; set; }

        [Required]
        [StringLength(25)]
        public string student_School { get; set; }

        public int sGroup_No { get; set; }

        public virtual StudentGroup StudentGroup { get; set; }
    }
}
