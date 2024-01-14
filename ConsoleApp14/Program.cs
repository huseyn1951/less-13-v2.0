using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
     public class Program
    {
       static void Main(string[] args)
        {
            Developer developer1 = new Developer("Efran","Ismayilov",36,200,"Delphi","Backend");
            Developer developer2 = new Developer("James","Lebron",37,3400,"JavaScript","Frontend");
            Accauntant accountant = new Accauntant("Tahir","Gozal",52,3000);
            ProjectManager manager = new ProjectManager("Qurban","Qurbanov",52,5000);
            Worker[] allWorkers = new Worker[] { manager, accountant, developer1, developer2 };
            Developer[] developers = new Developer[] { developer1, developer2 };
            ShowWorkers(allWorkers);
            developer1.ShowStack(developers);
            accountant.ShowSalary(allWorkers);
            accountant.ShowSalaryAvarage(allWorkers);
            ShowYoungest(allWorkers);
            manager.CreateProject("Misli application");


        }
        public static void ShowWorkers(Worker[] workers)
        {
            foreach (var worker in workers)
            {
                Console.WriteLine($" {worker.Name}  {worker.Surname} salary is: {worker.Salary}$");

            }
        }

        public static void ShowYoungest(Worker[] workers)

        {
            int age = 1000;
            string youngest = "";

            foreach (var worker in workers)
            {
                if (worker.Age < age)
                {
                    age = worker.Age;
                    youngest = worker.Name+ " " +worker.Surname;
                }
            }
            Console.WriteLine($"The youngest worker is {youngest}. he is {age} years old");
        }



    }
}
