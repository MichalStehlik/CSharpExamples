using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření počáteční kolekce dat
            List<Student> students = new List<Student> {
                new Student("Alfons","Avatar",15,3.4),
                new Student("Eve","Elektra",15,3.4),
                new Student {FirstName = "Břetislav", LastName = "Beowulf", Age = 18, AverageGrade = 4.0},
                new Student("Ctirad","Conan",16,1.4),
                new Student("Felix","Flash",14,1.0),
                new Student("Diane","Deadpool",19,4.4),
            };

            // https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.concat?view=netcore-3.1

            // Výpis kolekce
            Console.WriteLine("--- Complete list ---");
            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- List Ordered By Name ---");
            foreach (Student st in students.OrderBy(s => s.LastName))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- List Ordered By Grade ---");
            foreach (Student st in students.OrderByDescending(s => s.AverageGrade))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- List Ordered By Grade then Name ---");
            foreach (Student st in students.OrderByDescending(s => s.AverageGrade).ThenByDescending(s => s.LastName))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- Best 3 students ---");
            foreach (Student st in students.OrderBy(s => s.AverageGrade).Take(3))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- Just students over 18 years ---");
            foreach (Student st in students.Where(s => s.Age >= 18))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- All students with A in lastname ---");
            foreach (Student st in students.Where(s => s.LastName.Contains("a")))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- All students aged 1 year ---");
            foreach (Student st in students.Select(s => new Student(s.FirstName, s.LastName, s.Age + 1, s.AverageGrade)))
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("--- Best and worst Average Grade ---");
            Console.WriteLine(students.Min(st => st.AverageGrade));
            Console.WriteLine(students.Max(st => st.AverageGrade));

            Console.WriteLine("--- Number of students ---");
            Console.WriteLine(students.Count());

            Console.WriteLine("--- Number of older students ---");
            Console.WriteLine(students.Count(s => s.Age >= 18));

            Console.WriteLine("--- Average Grade ---");
            Console.WriteLine(students.Average(s => s.AverageGrade));

            Console.WriteLine("--- Sum of Grades ---");
            Console.WriteLine(students.Sum(s => s.AverageGrade));

            Console.WriteLine("--- Grouping of students by age ---");
            foreach (var st in students.GroupBy(s => s.Age, ((key, group) => new { Age = key, Count = group.Count()})))
            {
                Console.WriteLine(st.Age + " = " + st.Count);
            }
        }
    }
}
