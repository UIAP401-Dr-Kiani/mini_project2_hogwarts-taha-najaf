using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Student:AllowedPersons
    {
        public int PassedUnits { get; set; }
        public int Term { get; set; }
        public int DormitoryNumber { get; set; }

     }
}
