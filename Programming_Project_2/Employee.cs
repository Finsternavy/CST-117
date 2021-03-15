using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_2
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string email, string phone, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.age = age;
        }

        public string firstName = "Default-First";
        public string lastName = "Default-last";
        public string email = "default-email";
        public string phone = "515-000-0000";
        public int age = 18;
        public string preferredTeam = "Red Team";
        public string sex = "Male";

        //hold data user selected to make visible
        public List<string> visibleData = new List<string>();

        public void setFirstName(string name)
        {
            this.firstName = name;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setLastName(string name)
        {
            this.lastName = name;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public string getPhone()
        {
            return this.phone;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setPreferredTeam(string team)
        {
            this.preferredTeam = team;
        }

        public string getPreferredTeam()
        {
            return this.preferredTeam;
        }

        public void setSex(string sex)
        {
            this.sex = sex;
        }

        public string getSex()
        {
            return this.sex;
        }

        //format employee data based on their selection of visible data
        public StringBuilder employeeToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(string s in visibleData)
            {
                sb.Append(s);
                sb.Append("  ");
            }

            sb.Append("\n");

            Console.WriteLine(sb.ToString());
            return sb;
        }
    }
}
