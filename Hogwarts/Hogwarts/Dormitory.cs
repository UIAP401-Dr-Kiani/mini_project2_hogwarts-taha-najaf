using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Dormitory
    {
        public GroupType GroupType { get; set; }
        public int floor { get; set; }
        public int room { get; set; }
        public int bed { get; set; }
        public string gender { get; set; }
        public Dormitory (int num)
        {
            if (num/1000==0)// ones for bed,tens for room,hundreds for floor,if room number is less than 10
            {
                bed = num % 10;
                num/=10;
                room = num%10;
                num = num/10;
                floor = num%10;
            }
            else if (num/1000!=0)//if room number is 10
            {
                bed=num%10;
                room=10;
                floor = num / 1000;
            }
        }
    }
}
