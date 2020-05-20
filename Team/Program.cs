using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Team;

namespace ReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 4;
            var persons = new List<Person>();
            
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);

            }
            Team team = new Team("Lexicon");
            foreach (Person p in persons)
            {
                
                team.AddPlayer(p);
               
            }
            
            Console.WriteLine("First Team has {0}  players", team.FirstTeam.Count);
           
            Console.WriteLine("First Team has {0}  players", team.ReserveTeam.Count);

            //persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
        
    }
    
}
