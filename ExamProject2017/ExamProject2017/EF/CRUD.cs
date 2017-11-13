using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject2017.EF
{
    class CRUD
    {
        public static int AddJudgeGroup(string judgeGroupName){ 
            using (var context = new Model())
            {
                try
                {
                    var judgesGroup = new JudgesGroup() { jGroup_Name = judgeGroupName};
                    context.JudgesGroup.Add(judgesGroup);
                    context.SaveChanges();
                    return judgesGroup.jGroup_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }

        public static int AddNewStudent(string studenName, string studentSchool, int studentGroupNo)
        {
            using (var context = new Model())
            {
                try
                {
                    var student = new Student() { student_Name = studenName , student_School = studentSchool, sGroup_No = studentGroupNo };
                    context.Student.Add(student);
                    context.SaveChanges();
                    return student.student_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }

        public static int AddNewJudge(string judgeName, int judgeGroupNumber)
        {
            using (var context = new Model())
            {
                try
                {
                    var judge = new Judge() { judge_Name = judgeName, jGroup_No = judgeGroupNumber };
                    context.Judge.Add(judge);
                    context.SaveChanges();
                    return judge.judge_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }
    }
}
