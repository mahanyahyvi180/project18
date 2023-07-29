using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[] {new Employee("Jason","Red",500M),
                                   new Employee("Ashley","Green",7600M),
                                   new Employee("Matthew","Indigo",3587.5M),
                                   new Employee("James","Indigo",4700.77M),
                                   new Employee("Luke","Indigo",6200M),
                                   new Employee("Jason","Blue",3200M),
                                   new Employee("Wendy","Brown",4326.4M) };

            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }
            var between4k6k =
                from e in employees
                where (e.MonthlySalary >= 400M) && (e.MonthlySalary <= 6000M)
                select e;

            Console.WriteLine("\nEmployees earing in the range" + $"{4000:C}-{6000:C}per month:");

            foreach (var element in between4k6k)
            {
                Console.WriteLine(element);
            }

            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }

            var lastNames =
                from e in employees
                select e.LastName;

            Console.WriteLine("\nUnique employee last names:");

            foreach (var element in lastNames.Distinct())
            {
                Console.WriteLine(element);
            }

            var names =
                from e in employees
                select new { e.FirstName, e.LastName };

            Console.WriteLine("\nNames only:");

            foreach (var element in names)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
