using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioEmployee.Entities;

namespace ExercicioEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter the number of employes: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHour)); 
                }
         
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
