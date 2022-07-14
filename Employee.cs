using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object
{
    public enum Department { IT,Production,Civil,Sales,Accounts}
    class Employee
    {
        //prop 
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal salary { get; set; }
        public Department dept { get; set; }

        public static int count { get; set; }
        public Date dateofjoining { get; set; }


        //ctor
        public Employee()
        {
            Id = 1;
            Name = "Bill Gates";
            salary = 100000;
            dept = Department.IT;
        }
        public Employee(int Id, string Name, decimal salary, Department dept, Date dateofjoining)
        {
            this.Id = Id;
            this.Name = Name;
            this.salary = salary;
            this.dept = dept;
            this.dateofjoining = new Date(01,01,2022);
        }

        static Employee()
        {
            count++;
            Console.WriteLine("Total number of Employees "+count);
        }

        public override string ToString()
        {
            return Id+ " "+Name+" "+salary+" "+dept+" "+dateofjoining;
        }

        public virtual void GrossSal()
        {
            decimal gross = salary + salary * 0.7m + salary * 0.15m + 500;
            Console.WriteLine("Grooss salary of employee is" + gross); ;
        }
    }
}
