using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
   public class Accauntant:Worker
    {
        public Accauntant(string name, string surname, int age, int salary) : base(name, surname, age, salary) 
        {
        }
        public void ShowSalaryAvarage(Worker[] workers)

        {
            int sum = 0;
            foreach (var worker in workers)
            {
                sum += worker.Salary;
            }

            int avarage = sum / workers.Length;
            Console.WriteLine($"Worker's salary avarage is {avarage} $");
        }
        public void ShowSalary(Worker[] workers)
        {
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Surname} his salary is {worker.Salary}");
            }
        }
    }
}
