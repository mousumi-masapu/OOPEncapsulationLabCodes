﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementingEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 5;
            var persons = new List<Person>();
            for(int i=0; i<lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);

            }
            Console.WriteLine("Sort by First Name.......");

            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("Sort by Age......");
           
            persons.OrderBy(p => p.Age).ThenBy(p => p.FirstName).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
