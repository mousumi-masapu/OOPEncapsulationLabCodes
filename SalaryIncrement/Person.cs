using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryIncrement
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        decimal salary;
        public Person(string firstName, string lastName, int age,decimal salary)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

        }


         public decimal Salary
         {
             get
             {
                 return this.salary;
             }

         }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

       


        public void IncreaseSalary(decimal percentage)
        {
            //Console.WriteLine("Inside IncreaseSalary method" );

            if (this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;

            }
            else
            {

                this.salary += this.salary * percentage / 200;

            }
        
    }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} recieves {this.salary} dollars";
        }
    }
}
