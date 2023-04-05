using System;

namespace ConsoleApp1
{
    public class Teachers
    {
        internal int Age { get; set; }
        public string Name { get; set; }

        public Teachers(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public static void PrintInfoStatic(string name, int age) => Console.WriteLine($"Teacher Name: {name}, Teacher Age: {age}");
    }
}
