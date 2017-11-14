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
                new StudentGroup { sGroup_Name = "Red", category_No = 1},
                new StudentGroup { sGroup_Name = "Yeloow", category_No = 2},
                new StudentGroup { sGroup_Name = "Green", category_No = 1},
                new StudentGroup { sGroup_Name = "Black", category_No = 4},
                new StudentGroup { sGroup_Name = "Pink", category_No = 3},
                new StudentGroup { sGroup_Name = "Orange", category_No = 4},
                new StudentGroup { sGroup_Name = "Aqua", category_No = 3},
                new StudentGroup { sGroup_Name = "Blue", category_No = 2},
                new StudentGroup { sGroup_Name = "Lila", category_No = 1},


            };
            myStudentsGroup.ForEach(sG => context.StudentGroup.Add(sG));

            var myStudents = new List<Student>
            {
                //Add more students
                new Student { student_Name = "Bob", student_School = "EASV", sGroup_No = 1 },
                new Student {student_Name = "Mikkel Lunberg",student_School="Bornholms Erhvervsskole",sGroup_No = 2},
                new Student {student_Name = "Nikos Karakatsidis",student_School="Christianshavn School",sGroup_No = 3},
                new Student {student_Name = "Emilia Jensen",student_School="Efterslægten", sGroup_No = 1},
                new Student {student_Name = "Martynas Tumas",student_School="Frederiksberg Gymnasium", sGroup_No = 2},
                new Student {student_Name = "Luisa",student_School="Ishøj Gymnasium", sGroup_No = 3},
                new Student {student_Name = "David",student_School="Krebs School", sGroup_No = 1},
                new Student {student_Name = "Kasper",student_School="Nørre Gymnasium" , sGroup_No = 2}
            };
            myStudents.ForEach(s => context.Student.Add(s));


            var myJudgesGroup = new List<JudgesGroup>
            {
                //Add more jGroups
                new JudgesGroup { jGroup_Name = "A"},
                new JudgesGroup { jGroup_Name = "B"},
                new JudgesGroup { jGroup_Name = "C"},
                new JudgesGroup { jGroup_Name = "D"},
                new JudgesGroup { jGroup_Name = "E"},
                new JudgesGroup { jGroup_Name = "F"},
                new JudgesGroup { jGroup_Name = "G"},
                new JudgesGroup { jGroup_Name = "H"},
                new JudgesGroup { jGroup_Name = "I"}
            };
            myJudgesGroup.ForEach(jG => context.JudgesGroup.Add(jG));

            var myJudges = new List<Judge>
            {
                //Add more judges
                new Judge { judge_Name = "Max", jGroup_No = 1},
                new Judge { judge_Name = "Bob", jGroup_No = 1},
                new Judge { judge_Name = "Bobby", jGroup_No = 2},
                new Judge { judge_Name = "Mongol", jGroup_No = 2},
                new Judge { judge_Name = "Tuna", jGroup_No = 3},
                new Judge { judge_Name = "Bo", jGroup_No = 3},
                

            };
            myJudges.ForEach(j => context.Judge.Add(j));

            context.SaveChanges();
        }
    }
}
