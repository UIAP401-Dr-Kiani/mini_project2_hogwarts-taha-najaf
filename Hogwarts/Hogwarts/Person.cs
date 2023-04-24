using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Birthday { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public int Username { get; set;}
        public int Password { get; set; }
        public BreedType breedType { get ; set; } 
    }
}
