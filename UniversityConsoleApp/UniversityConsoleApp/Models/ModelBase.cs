using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.BL;

namespace UniversityConsoleApp.Models
{
    public class ModelBase
    {
        public Guid ID { get; } = Guid.NewGuid();
    }
}
