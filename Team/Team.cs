using System;
using System.Collections.Generic;
using System.Text;
using Team;

namespace ReserveTeam
{
    class Team
    {
        

        private string name;
        private int age;
        private List<Person> firstTeam;
        private List<Person> reverseTeam;

       
        public Team(string name)
        {
            
            this.firstTeam = new List<Person>();
            this.reverseTeam = new List<Person>();
            this.name = name;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public List<Person> FirstTeam
        {
            get
            {
                return this.firstTeam;
            }
        }
        public List<Person> ReserveTeam
        {
            get
            {
                return this.reverseTeam;
            }
        }

        public void AddPlayer(Person player)
        {
            //Console.WriteLine("Inside AddPlayer method");
            //Console.WriteLine("player.Age" + player.Age);
            if (player.Age< 40)
            {
                firstTeam.Add(player);
                Console.WriteLine("First Team has {0}  players", firstTeam.Count);

            }
            else
            {
                reverseTeam.Add(player);
                Console.WriteLine("Reverse Team has {0}  players", reverseTeam.Count);

            }
           
            
        }

    }
}
