using Internship.Institution;
using Internship.Institution.InterLink;
using Internship.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new University
            University CHNU = new University("The Bohdan Khmelnytsky National University of Cherkasy");

            // Add students to University
            CHNU.AddStudent(new Student("Nikita Ivanov", 100));
            CHNU.AddStudent(new Student("Alina Tsymbal", 95));
            CHNU.AddStudent(new Student("Volodymyr Khandiuk", 85));
            CHNU.AddStudent(new Student("Stepan Karpov", 73));
            CHNU.AddStudent(new Student("Julia Veselkina", 58));
            CHNU.AddStudent(new Student("Stas Voidenko", 41));
            CHNU.AddStudent(new Student("Maria Perechrest", 25));
            CHNU.AddStudent(new Student("Serhii Yatsyn", 1));

            // Display the list of students
            CHNU.ShowAllStudents();
            // Display University average score
            Console.WriteLine("\nCHNU average score is {0}", CHNU.AverageScore());

            // Create new Intership
            InternshipInCamp InCamp = new InternshipInCamp("Interlink");

            // Check all students
            InCamp.StudentValidation(CHNU);
            // Display suitable students
            InCamp.GetStudents();
        }
    }
}
