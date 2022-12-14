using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphizm
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;

        public Student(string name, string surname, string group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Group}";
        }
    }
}
