using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEmployee
{
    public class Employee
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

}