using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Teacher:Human
    {
        public Teacher(string name):base(name)
        {

        }
        public Teacher(string name,string surname,double salary) : base(name,surname)
        {
            Salary = salary;
        }

        public double Salary;
    }
}
