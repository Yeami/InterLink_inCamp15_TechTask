using Internship.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Institution.InterLink
{
    public class InternshipInCamp
    {
        public List<Student> Students;

        public string Name { get; set; }

        public InternshipInCamp(string Name)
        {
            this.Name = Name;
            this.Students = new List<Student>();
        }

        public void StudentValidation(University University)
        {
            foreach (Student Student in University.Students)
            {
                if (Student.StudentKnowledge.Level >= University.AverageScore())
                {
                    this.Students.Add(Student);
                }
            }
        }

        public void GetStudents()
        {
            Console.WriteLine("\nThe list of {0} Intership students:", Name);

            foreach (Student Student in Students)
            {
                Console.WriteLine(Student.ToString());
            }
            Console.WriteLine();
        }
    }
}
