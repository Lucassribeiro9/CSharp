﻿using ExempIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExempIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\ESD\teste.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException msg)
            {
                Console.WriteLine("Error: " + msg);
            }
            
        }
    }
}
