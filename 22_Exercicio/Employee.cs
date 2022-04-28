using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Exercicio
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee (int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increasetSalary(double percentage)
        {
            return Salary += x / 100;
        }

    }
}
