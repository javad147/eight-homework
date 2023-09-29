using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    internal class Employee
    {
        public int id;
        public string name;
        public string surname;
        public string address;
        public string email;
        public int age;


        public static int CountEmployeesInAgeRange(Employee[] employees, int n, int m)
        {
            int count = 0;

            foreach (var employee in employees)
            {
                if (employee.age >= n && employee.age <= m)
                {
                    count++;
                }
            }

            return count;
        }

        public static int SumOfAge(Employee[] employees)
        {
            int sum = 0;
            foreach (var employee in employees)
            {
                sum += employee.age;
            }
            return sum;

        }

        public static void FindEmailsByFirstLetter(Employee[] employees, string letter)
        {
            foreach (var employee in employees)
            {
                if (employee.email.StartsWith(letter.ToString().ToLower().Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{employee.name} {employee.surname}");
                }
            }
        }

        public static void FindByNumber(Employee[] employees, int number)
        {
            foreach (var employee in employees)
                if (employee.age >= number)
                {
                    Console.WriteLine($"{employee.name} {employee.surname}");
                }

        }
    }
}
