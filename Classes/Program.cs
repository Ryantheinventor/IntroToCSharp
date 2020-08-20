using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Team theTeam = new Team();
            theTeam.employees.Add(new Employee("Steve", "Jobs", 5));
            theTeam.employees.Add(new Employee("Bill", "Gates", 6));
            theTeam.employees.Add(new Employee("Bob", "Ross", 2));
            theTeam.employees.Add(new Employee("Jack", "Jackson", 4));

            theTeam.teamLead = new Employee("George","Hill",8);

            Console.WriteLine(theTeam.AverageYearsOfExperience());
            List<int> aadsf = new List<int>();
            aadsf.Add(1);
            aadsf.Add(1);
            aadsf.Add(1);
            aadsf.Add(1);


            /*
            Circle a = new Circle(new Vector2(1, 0), 1);
            Circle b = new Circle(new Vector2(5, 0), 1);
            Circle c = new Circle(new Vector2(5, 0), 6);


            Console.WriteLine(a.CheckOverlap(b));
            Console.WriteLine(a.CheckOverlap(c));
            */
            Console.ReadLine();
            
        }
    }
}
