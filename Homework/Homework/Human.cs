using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Human
    {
        public Human(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Human(string name)
        {
            Name = name;
        }

       


        public string Name;
        public string Surname;
        public byte Age;

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
