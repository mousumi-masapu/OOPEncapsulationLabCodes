using System;
using System.Collections.Generic;
using System.Text;

namespace Team
{
    class Person
    {

        private string firstName;
        private string lastName;
        private int age;
    
    public Person(string firstName, string lastName, int age)
    {

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        

    }
    public int Age
    {
        get
        {

            return this.age;
        }


    }
        /*public int FirstName
        {
            get
            {

                return firstName;
            }


        }*/
        public int LastName
        {
            get
            {

                return this.LastName;
            }


        }
        /*public override string ToString()
        {
            return $"{this.firstName} {this.lastName} recieves {this.salary} dollars";
        }*/
    }
}
