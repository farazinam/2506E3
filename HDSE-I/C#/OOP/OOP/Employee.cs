using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        string id;
        string name;
        string city;
        int salary;

        //setter method
        public void setter(string i, string n, string c, int s)
        {
            this.id = i;
            this.name = n;
            this.city = c;
            this.salary = s;
        }

        //getter method
        public void getter()
        {
            Console.WriteLine($"Employee ID is {id} \nName is {name} \nCity is {city} \nSalary is {salary}");
        }

    }
}
