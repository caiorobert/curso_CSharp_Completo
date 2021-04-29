using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");// D:\source\repos\curso_CSharp_Completo\Exercicios\Capitulo17\2.Exercicio\in.csv
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                var emails = employees.Where(p => p.Salary > limit).OrderBy(p => p.Email).Select(p => p.Email);

                var sum = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();

                Console.WriteLine($"Email of people whose salary is more than ${limit}:");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.Write($"Sum of salary of people whose name starts with 'M': ${sum}");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
