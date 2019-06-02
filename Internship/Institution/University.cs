using Internship.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Institution
{
    public class University
    {
        public List<Student> Students;

        public string Name { get; set; }

        public University(string Name)
        {
            this.Name = Name;
            this.Students = new List<Student>();
        }

        public void AddStudent(Student Student)
        {
            this.Students.Add(Student);
        }

        public double AverageScore()
        {
            double Score = 0;
            double Average = 0;

            foreach (Student Student in Students)
            {
                Score += Student.StudentKnowledge.Level;
            }

            Average = Score / Students.Count;

            return Average;
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("The list of {0} students:", Name);

            foreach (Student Student in Students)
            {
                Console.WriteLine(Student.ToString());
            }
        }
    }
}
