using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.BL;

namespace UniversityConsoleApp.Interfaces
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(List<Person> persons);
    }
}
