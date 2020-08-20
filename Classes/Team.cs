using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Team
    {
        public List<Employee> employees = new List<Employee>();
        public Employee teamLead;

        public int AverageYearsOfExperience() 
        {
            int totalYears = teamLead.yearsOfExperience;
            foreach (Employee e in employees) 
            {
                totalYears += e.yearsOfExperience;
            }
            return totalYears / (employees.Count + 1);
        }
    }
}
