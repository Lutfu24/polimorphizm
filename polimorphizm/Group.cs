using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphizm
{
    internal class Group
    {
        public string No;
        public byte Limit = 2;
        private Student[] Students = new Student[0];
        
        public void AddStudent()
        {
            Console.WriteLine("Name daxil edin:");
            Console.WriteLine("Surname daxil edin:");
            Console.WriteLine("Group daxil edin:");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string group = Console.ReadLine();
            Student student = new Student(name, surname, group);
            if (this.Students.Length<=Limit)
            {
                Array.Resize(ref this.Students, this.Students.Length + 1);
                this.Students[this.Students.Length - 1] = student;
                Console.WriteLine("Student elave olundu");
            }
            else
            {
                Console.WriteLine("Student elave olunmadı");
            }
            
        }

        public void GetStudent()
        {
            foreach (var item in this.Students)
            {
                Console.WriteLine(item);
            }
        }
    }

}
