using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.BL;

namespace UniversityConsoleApp.Interfaces
{
    public interface IManager
    {
        Person Create(string firstName, string lastName, int age);
        List<Person> Create(int count, int minAge);
    }
}
