using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class AllowedPersons:Person
    {
        public string Curriculum { get; set; }
        public Pet Pet { get; set; }
        public Group GroupName { get; set; }
        public bool HaveBaggage { get; set; }
        public Role Role { get; set; }
        public string ReceivedLetter { get; set; }
    }
}
