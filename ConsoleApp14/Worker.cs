using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
     public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Worker(string name, string surname, int age, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;  
        }

    }
}
