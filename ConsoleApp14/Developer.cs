using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
    public class Developer:Worker
    {
        public string ProgrammingLanguage { get; set; }
        public string WayOfProgramming { get; set; }


        public Developer(string name, string surname, int age, int salary, string programmingLanguage, string wayOfProg) : base(name, surname, age, salary)
        {
            ProgrammingLanguage = programmingLanguage;
            WayOfProgramming = wayOfProg;
            ;
        }

        public  void ShowStack(Developer[] workers)

        { 
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Surname}, his way of programming is {worker.WayOfProgramming}, his programming language is {worker.ProgrammingLanguage}");
            }
        }

    }
}
