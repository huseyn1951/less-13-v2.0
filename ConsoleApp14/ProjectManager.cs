using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
    public class ProjectManager:Worker
    {
        public ProjectManager(string name, string surname, int age, int salary) : base(name, surname, age, salary) 
        {
        }

        public void CreateProject(string Project)
        {
            Console.WriteLine($"{Name} {Surname} created this project:{Project}");
        }
    }
}
