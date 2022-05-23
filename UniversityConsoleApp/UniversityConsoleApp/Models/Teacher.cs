using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.BL;

namespace UniversityConsoleApp.Models
{
    public class Teacher : Person
    {
        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
        public Teacher(string firstName, string lastName, int age, List<Student> students) : base(firstName, lastName, age)
        {
            Students = students;
        }
        public Teacher(string firstName, string lastName, int age, List<Student> students, Group _group) : base(firstName, lastName, age)
        {
            Students = students;
            Group = _group;
        }
        public Group Group { set; get; }
        public List<Student> Students { set; get; }
    }
}
