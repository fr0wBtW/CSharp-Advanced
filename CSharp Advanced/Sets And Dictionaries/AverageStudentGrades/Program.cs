using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentDictionary = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputNumber; i++)
            {
                var studentInfo = Console.ReadLine().Split(' ').ToArray();
                string studentName = studentInfo[0];
                var studentGrade = double.Parse(studentInfo[1]);

                if (!studentDictionary.ContainsKey(studentName))
                {
                    studentDictionary[studentName] = new List<double>();

                }
                studentDictionary[studentName].Add(studentGrade);
            }
            foreach (var student in studentDictionary)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x => x.ToString("f2")))} " +
                    $"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
