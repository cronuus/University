using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConsoleApp.Models
{
    public class Group : ModelBase
    {
        public string Name { get; set; }
        public Group()
        {
        }

        public Group(string name)
        {
            Name = name;
        }
    }
}
