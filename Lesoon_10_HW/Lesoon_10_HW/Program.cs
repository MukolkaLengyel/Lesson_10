using System.Security.Cryptography.X509Certificates;

namespace Lesoon_10_HW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student(1, 18, 112, "Jon Doe");
            Student student2 = new Student(2, 14, 222, "Semjon Semjonovich");
            Teachers teacher1 = new Teachers(3, 33, "Jacky Jackson");
            Teachers teacher2 = new Teachers(4, 34, "Sammy");

            student1.ClassRoom = 5;
            student2.ClassRoom = 10;

            Student.PrintInfoStatic(student1.Name, student1.Age, student1.ClassRoom);
            Student.PrintInfoStatic(student2.Name, student2.Age, student2.ClassRoom);
            Teachers.PrintInfoStatic(teacher1.Name, teacher1.Age);
            Teachers.PrintInfoStatic(teacher2.Name, teacher2.Age);
        }

        public class Student
        { 
            public int Age { get; set; }
            public int Id { get; set; }
            public int ClassRoom { get; set; }
            public string Name { get; set; }

            public Student(int id, int age, int classRoom, string name)
            {
                Id = id;
                Age = age;
                Name = name;
                ClassRoom = classRoom;
            }
            public static void PrintInfoStatic(int classRoom) => Console.WriteLine($"Class Room: {classRoom}");
            public static void PrintInfoStatic(string name, int age, int classRoom) => Console.WriteLine($"Student Name: {name}, Student Age: {age}, Class Room: {classRoom}");
        }

        public class Teachers
        {
            public int Id { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }

            public Teachers (int id, int age, string name)
            {
                Id = id;
                Age = age;
                Name = name;
            }

            public static void PrintInfoStatic(string name, int age) => Console.WriteLine($"Teacher Name: {name}, Teacher Age: {age}");
        }
    }
}