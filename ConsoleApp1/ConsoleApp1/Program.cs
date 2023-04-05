using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student(1, 18, 122, "Jony Don");

            studentRec rec = new ();
            rec = new("Jony", "Don", 18);
            rec = rec with { Age = 19 };

            Teachers teachers = new Teachers("G.Garry", 36);
            teachersRec rec1 = new ("G.", "Garry", 41);
            rec1 = rec1 with { Age = 35 };

            Student.PrintInfoStatic(student.Name, student.Age, student.ClassRoom);
            Teachers.PrintInfoStatic(teachers.Name, teachers.Age);
        }

        public record studentRec(string FirstName = "Jon", string LastName = "Doe", int Age = 18);
        public record teachersRec(string FirstName = "G.", string LastName = "Garry", int Age = 41);


        
    }
}