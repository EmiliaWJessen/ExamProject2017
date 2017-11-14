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

        public static int AddCategory(string categoryName)
        {
            using (var context = new Model())
            {
                try
                {
                    var category = new Category() { category_Name = categoryName };
                    context.Category.Add(category);
                    context.SaveChanges();
                    return category.category_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }

        public static int AddStudentGroup(string studentGroupName, int categoryNumber)
        {
            using (var context = new Model())
            {
                try
                {
                    var studentGroup = new StudentGroup() { sGroup_Name = studentGroupName, category_No = categoryNumber };
                    context.StudentGroup.Add(studentGroup);
                    context.SaveChanges();
                    return studentGroup.sGroup_No;
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

        public static int AddNewEvent(DateTime eventDate)
        {
            using (var context = new Model())
            {
                try
                {
                    var eventE = new Event() { event_Date = eventDate };
                    context.Event.Add(eventE);
                    context.SaveChanges();
                    return eventE.event_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }
        public static int AddNewQuestion(string questionText)
        {
            using (var context = new Model())
            {
                try
                {
                    var question = new Question() { question_Text = questionText };
                    context.Question.Add(question);
                    context.SaveChanges();
                    return question.question_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }

        public static int AddNewResult(int rankingNumber, int resultPoints, int questionNumber)
        {
            using (var context = new Model())
            {
                try
                {
                    var result = new Result() { ranking_No = rankingNumber, question_No = questionNumber, result_Points = resultPoints };
                    context.Result.Add(result);
                    context.SaveChanges();
                    return result.result_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }

        public static int AddNewRanking(int eventNumber, int sGroupNumber, int jGroupNumber)
        {
            using (var context = new Model())
            {
                try
                {
                    var ranking = new Ranking() { event_No = eventNumber, sGroup_No = sGroupNumber, jGroup_No = jGroupNumber };
                    context.Ranking.Add(ranking);
                    context.SaveChanges();
                    return ranking.ranking_No;
                }
                catch (Exception ex) { Console.WriteLine(ex.InnerException.Message); return 0; }
            }
        }
    }
}
