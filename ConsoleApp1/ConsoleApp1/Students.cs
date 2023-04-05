using System;

namespace ConsoleApp1
{
    public class Student
    {
        public int Age { get; set; }
        private int Id { get; set; }
        internal int ClassRoom { get; set; }
        protected internal string Name { get; set; }

        public Student(int id, int age, int classRoom, string name)
        {
            Id = id;
            Age = age;
            Name = name;
            ClassRoom = classRoom;
        }

        public static void PrintInfoStatic(int classRoom) => Console.WriteLine($"Class Room: {classRoom}");
        public static void PrintInfoStatic(string name, int _age, int classRoom) => Console.WriteLine($"Student Name: {name}, Student Age: {_age}, Class Room: {classRoom}");
    }
}