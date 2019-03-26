using System;
using System.Collections.Generic;

namespace StudentAverage
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student studentNameAndScores = new Student();
            students = studentNameAndScores.GetStudentScoresFromFileStudentData();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Average: {student.GetAverage()}");
            }

            Console.ReadLine();

        }
    }
}