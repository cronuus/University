using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.BL;

namespace UniversityConsoleApp.Models
{
    public class Person : ModelBase
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        int _age;

        public int Age
        {
            get => _age;
            set => _age = 10 < value && value < 80 ? value : throw new ArgumentException("Invalid age range");
        }
    }
}
