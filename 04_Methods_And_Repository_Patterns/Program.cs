﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods_And_Repository_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            var age = GetAge();

            Hello(name);
            Console.WriteLine($"You are {age} years old.");
            Console.ReadKey();
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}.");
        }

        static int GetAge()
        {
            Console.WriteLine("Enter your age:");
            var age = int.Parse(Console.ReadLine());
            return age;
        }
    }
}
