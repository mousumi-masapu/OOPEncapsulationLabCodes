using System;
using System.Collections.Generic;
using System.Text;

namespace DataValidation
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;

        }
          
        public string FirstName
        {
                
            set
            {

                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException("FirstName cannot contain les than 3 characters");

                }
                this.firstName = value;
            }
            

        }

        public string LastName
        {
           
            set
            {

                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException("LastName cannot contain les than 3 characters");

                }
                this.lastName = value;

            }


        }

        public int Age
        {
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a naegative number");

                }

                this.age = value;
            }


        }

        public decimal Salary
        {
            get
            {
                return this.salary;//requires get as it has private set
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less then 460 dollars");
                }
                this.salary = value;
            }

        }

        /*public override string ToString()
        {
            return $"{this.firstName} {this.lastName} recieves {this.salary} dollars";
        }*/
        }
    
    }


       

