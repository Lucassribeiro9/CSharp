using ExLinqSr.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExLinqSr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();
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
                        list.Add(new Employee(name, email, salary));
                    }
                }
                var emails = list.Where(p => p.Salary > limit).OrderBy(p => p.Email).Select(p => p.Email);
                var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
                Console.WriteLine($"Email of people whose salary is more than {limit}: ");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (IOException err)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(err.Message);
            }

        }
    }
}
