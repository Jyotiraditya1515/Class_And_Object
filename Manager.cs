using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object
{
    class Manager:Employee
    {
        public int Salesqty { get; set; }
        public decimal Commission  { get; set; }
        public Manager()
        {
            Salesqty = 1000;
            Commission = 200;
        }
        public Manager(decimal Commission, int Salesqty, int id, string name, decimal sal, Department dept, Date dt) : base(id, name, sal, dept, dt)
        {
            this.Commission = Commission;
            this.Salesqty = Salesqty;
        }
        public override void GrossSal()
        {
            decimal gross = salary + salary * 0.7m + salary * 0.15m + 500 +Commission*salary;
            Console.WriteLine("Gross Salary of Manager is "+gross);
        }
    }
}
