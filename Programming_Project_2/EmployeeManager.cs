using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_2
{
    public class EmployeeManager
    {
        public EmployeeManager()
        {

        }

        //List to hold multiple employees to show data is retained for multiple entries
        public List<Employee> employees = new List<Employee>();

        //formatting for printing all employees in a readable format
        public StringBuilder employeesToString()
        {
            StringBuilder sb = new StringBuilder();

            //iterate through each employee and print their visible data
            foreach(Employee employee in employees)
            {
                sb.Append(employee.employeeToString());
            }

            return sb; 
        }
    }
}
