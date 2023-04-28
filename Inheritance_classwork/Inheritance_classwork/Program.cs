using System;

namespace Inheritance_classwork;
using static Inheritance_classwork.Class1;

public class Program
    {
        
        static void Main(string[] args)
        {
        var employee = new Employee
        {
            Name = "Zuli",
            Surname = "SS",
            Age = 22,
            SalaryOfHour = 200,
            WorkingHour = 6
        };

        
        var salary = employee.CalculateSalary();

       
        Console.WriteLine($"Iscinin maasi: {salary} manats");

        Console.ReadKey();
        }
    }
