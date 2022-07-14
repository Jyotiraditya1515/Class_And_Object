using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object
{
    class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return day+" "+month+" "+year;
        }
    }
}
