using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Person
{
    public class Student
    {
        public string Name { get; set; }
        public Knowledge StudentKnowledge { get; set; }

        public Student(string Name, int Level)
        {
            this.Name = Name;
            this.StudentKnowledge = new Knowledge(Level);
        }

        public override string ToString()
        {
            return this.Name + " average score is " + this.StudentKnowledge.Level;
        }
    }
}
