using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class Student<T>
    {
        public string Name { get; set; }
        public List<T> Grades { get; set; }
        public Student(string name,List<T> grades)
        {
            Name = name;
            Grades = grades;
        }
    }
}
