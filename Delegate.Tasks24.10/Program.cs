using Delegate.Tasks24._10.Models;

namespace Delegate.Tasks24._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1
            //List<Person> People = new List<Person>
            //{
            //    new Person{Name="Xeyal", Surname="ov",Age=20},
            //    new Person{Name="Yusif", Surname="li", Age=19},
            //    new Person{Name="Aytekin", Surname="ova", Age=18},
            //    new Person{Name="Samir", Surname="ov", Age=22},
            //    new Person{Name="Aynur", Surname="ova", Age=43}
            //};
            //List<Person> a = People.FindAll(p => p.Name == "Xeyal");
            //Console.WriteLine("Adı Xeyal olanlar:");
            //foreach (var person in a)
            //{
            //    Console.WriteLine($"{person.Name} - {person.Surname} - {person.Age}");
            //}
            //List<Person> b = People.FindAll(p => p.Surname.EndsWith("ov") && p.Surname.EndsWith("ova"));
            //Console.WriteLine("\nSoyadı ov ve ova ile bitenler:");
            //foreach (var person in b)
            //{
            //    Console.WriteLine($"{person.Name} - {person.Surname} - {person.Age}");
            //}
            //List<Person> c = People.FindAll(p => p.Age >= 20);
            //Console.WriteLine("\nYaşı 20+ olanlar:");
            //foreach (var person in c)
            //{
            //    Console.WriteLine($"{person.Name} - {person.Surname} - {person.Age}");
            //}


            //TASK-2
            //List<Exam> exams = new List<Exam>();

            //exams.Add(new Exam { Subject = "Full-Stack", ExamDuration = TimeSpan.FromHours(1), StartDate = DateTime.Now.AddHours(3) });
            //exams.Add(new Exam { Subject = "Back-End", ExamDuration = TimeSpan.FromHours(6), StartDate = DateTime.Now.AddHours(-4) });
            //exams.Add(new Exam { Subject = "System", ExamDuration = TimeSpan.FromHours(2), StartDate = DateTime.Now.AddHours(1) });
            //exams.Add(new Exam { Subject = "Front-End", ExamDuration = TimeSpan.FromHours(5), StartDate = DateTime.Now.AddHours(-4) });

            //Console.WriteLine("Son 1 hefte erzinde olan examlar:");
            //List<Exam> lastWeekExams = exams.FindAll(e => (DateTime.Now - e.StartDate).TotalDays <= 7);
            //ShowExams(lastWeekExams);

            //Console.WriteLine("\n2 saatdan uzun ceken imtahanlarin siyahisi:");
            //List<Exam> longExams = exams.FindAll(e => e.ExamDuration.TotalHours > 2);
            //ShowExams(longExams);

            //Console.WriteLine("\nBashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi:");
            //List<Exam> goingExams = exams.FindAll(e => e.StartDate <= DateTime.Now && DateTime.Now <= e.EndDate);
            //ShowExams(goingExams);
        }
        //static void ShowExams(List<Exam> examList)
        //{
        //    foreach (var exam in examList)
        //    {
        //        Console.WriteLine($"Subject: {exam.Subject}");
        //        Console.WriteLine($"Exam Duration: {exam.ExamDuration.TotalHours} hours");
        //        Console.WriteLine();
        //    }
        //}
    }
}