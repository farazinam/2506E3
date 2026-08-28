using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    internal class Abstraction
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public double salary {  get; set; }
        public double netPay;
        public double grossPay;
        public double textDeduction = 0.1;

        public void employee(int i, string n, double gpay)
        {
            this.id = i;
            this.name = n;
            this.grossPay = gpay;
        }

        private void calculateSalary()
        {
            if (grossPay > 50000)
            {
                netPay = grossPay - (grossPay * textDeduction);
                Console.WriteLine($"Your Net Pay is {netPay}");
            }
        }

        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee Details");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Name: {name}");
            calculateSalary();
        }
    }

    public abstract class Animal
    {
        public abstract void makeSound();

    }

    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }
}
