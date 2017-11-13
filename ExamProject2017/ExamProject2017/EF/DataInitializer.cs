using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject2017.EF
{
    class DataInitializer: DropCreateDatabaseAlways<Model>
    {
        protected override void Seed(Model context)
        {
            Console.WriteLine("Seed called");

            var myStudentsGroup = new List<StudentGroup>
            {
                //Add more sGroups
                new StudentGroup { sGroup_Name = "", category_No = 1},

            };
            myStudentsGroup.ForEach(sG => context.StudentGroup.Add(sG));

            var myStudents = new List<Student>
            {
                //Add more students
                new Student { student_Name = "Bob", student_School = "EASV", sGroup_No = 1 }
            };
            myStudents.ForEach(s => context.Student.Add(s));


            var myJudgesGroup = new List<JudgesGroup>
            {
                //Add more jGroups
                new JudgesGroup { jGroup_Name = "A"},
            };
            myJudgesGroup.ForEach(jG => context.JudgesGroup.Add(jG));

            var myJudges = new List<Judge>
            {
                //Add more judges
                new Judge { judge_Name = "Poul", jGroup_No = 1}
            };
            myJudges.ForEach(j => context.Judge.Add(j));

            context.SaveChanges();
        }
    }
}
