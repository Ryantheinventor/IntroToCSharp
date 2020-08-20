using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        public string firstName, lastName;
        public int yearsOfExperience;

        public Employee(string firstName, string lastName, int yearsOfExperience) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearsOfExperience = yearsOfExperience;
        }
        public void PrintEmployeeInfo() 
        {
            Console.WriteLine($"{firstName} {lastName} with {yearsOfExperience} years of experience.");
        }
    }
}
