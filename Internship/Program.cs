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
            var s = new Student("Alex");
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko"));
            university.AddStudent(new Student("Julia Veselkina"));
            university.AddStudent(new Student("Maria Perechrest"));

            InternshipInCamp internship = new InternshipInCamp("Interlink");
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
