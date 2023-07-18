using System;
using System.Globalization;
using System.Collections.Generic;
using Ex35.Entities;

namespace Ex35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Employee e = new Employee();
            //Contract c = new Contract();

            Console.Write("Add contracts? (s/n) ");
            char add = char.Parse(Console.ReadLine().ToLower());

            Employee employee = new Employee();

            var count = 0;
            while(add == 's')
            {
                count += 1;
                Console.WriteLine($"\nContract #{count}");

                int id = random.Next(10000, 99990);
                Console.Write("Enter the employee name: ");
                string name = Console.ReadLine();

                int idContract = random.Next(10000, 99999);
                Console.Write("Enter the salary: $ ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee = new Employee(id, name);
                Contract contract = new Contract(idContract, salary, employee);

                employee = new Employee(contract);

                Console.Write("\nAdd contracts? (s/n) ");
                add = char.Parse(Console.ReadLine().ToLower());
            }

            double averageWage = employee.AverageWage();
            double highestSalary = employee.HighestSalary();

            Console.WriteLine("\nList of employees: ");

            foreach(Contract contract in employee.Contracts)
            {
                Console.WriteLine(contract);
            }
        }   
    }
}