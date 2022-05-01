using System;
using System.Collections.Generic;
using System.Globalization;

namespace _22_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            
            Console.Write("How many employees will be registered: ");
            int nEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nEmployees; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee employee = new Employee(id, nome, salario);
                list.Add(employee);
            }

            Console.Write("Enter the employee ID that will have salary increase: ");
            int Id = int.Parse(Console.ReadLine());
            Employee employeeFound = list.Find(employee => employee.Id == Id);

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employeeFound.RaiseSalary(percentage);

            Console.WriteLine(employeeFound.ToString());

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.ToString());
                Console.WriteLine("Update list of employees: " + emp.ToString());
            }

            
          
        }
    }
}
