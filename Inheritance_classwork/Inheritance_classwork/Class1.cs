using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_classwork;


class Class1
{
    public class Person
    {
        private int _age;

        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("18 yasdan asagi islemek olmaz");
                    return;
                }
                
                _age = value;
            }
        }

    }

    public class Employee : Person
    {

        private int _salaryOfHour;
        private int _workingHour;

        public int SalaryOfHour { get; set; }
        public int WorkingHour 
        {
            get => _workingHour;
            set
            {
                if (value > 8)
                {
                    Console.WriteLine("8 saatdan cox is olmaz");
                    return;
                }
               
                _workingHour = value;
            }
        }
        public int CalculateSalary()
        {
            int salary = SalaryOfHour * WorkingHour;
            if (salary < 250)
            {
                return 250;
            }
            return salary;
        }
    }

    public class Student : Person
    {
        private int _iqRank;
        private int _languageRank;

        public int IQRank
        {
            get => _iqRank;
            set
            {
                if (value < 0 && value > 100)
                {
                    Console.WriteLine("0-100 arasinda eded daxil edin");
                }
                _iqRank = value;
            }
        }
        public int LanguageRank
        {
            get => _languageRank;
            set
            {
                if (value < 0 && value > 100)
                {
                    Console.WriteLine("0-100 arasinda eded daxil edin");
                }
                _languageRank = value;
            }
        }
        public void ExamResult()
        {
            if (IQRank < 120 && LanguageRank < 120)
            {
                Console.WriteLine("Sagird sinifde qalir");
            }
        }
        public Student(string name, string surname, int age, int iqRank, int languageRank)
        {
            if (age < 6 || age > 20)
            {
                Console.WriteLine("Sagird yasi 6-20 arasi olmalidir");
            }

            Name = name;
            Surname = surname;
            Age = age;
            IQRank = iqRank;
            LanguageRank = languageRank;
        }
    }

}
