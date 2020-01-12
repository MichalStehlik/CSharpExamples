using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    class Student
    {
        public Student(string firstName, string lastName, int age, double averageGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            AverageGrade = averageGrade;
        }

        public Student() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageGrade { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName + " (" + Age + "y, " + AverageGrade + ")";
        }
    }
}
