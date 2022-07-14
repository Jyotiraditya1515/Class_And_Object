using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object
{
    public class Student
    {
        int id;
        string firstname;
        string lastname;
        int marks;
        public Student(int id, string firstname, string lastname, int marks)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.marks = marks;
        }
        public override string ToString()
        {
            return id + " " +firstname + " " + lastname + " " + marks;
        }
    }
}
