using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    internal class Encapsulation
    {
        private int atmpin;

        public void getter()
        {
            Console.WriteLine($"Your ATM Pin in {atmpin}");
        }

        public void setter(int pin)
        {
            this.atmpin = pin;
        }
    }

    public class BankAccount
    {
        private decimal balance = 0;

        public void deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void getbalance()
        {
            Console.WriteLine($"Your Current Balance is {balance}");
        }
    }

    public class Meezan
    {
        private decimal balance;
        private int accountNo;
        private string ownerName;

        public Meezan(decimal b, int a, string o)
        {
            this.balance = b;
            this.accountNo = a;
            this.ownerName = o;
        }

        public void getOwnerName()
        {
            Console.WriteLine($"Owner name is {ownerName}");
        }

        public void getAccountNo()
        {
            Console.WriteLine($" Account No is {accountNo}");
        }

        public void balaceEnquiry()
        {
            Console.WriteLine($"Current Balance is {balance}");
        }

        public void deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} Depositeed Successfully");
            }
            else
            {
                Console.WriteLine("Please Provide Valid Amount");
            }
        }

        public void withdrawl(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
            }
        }
    }


    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Contact;

        public abstract void getDetails();
    }

    public class Student : Person
    {
        public string RollNo;
        public int Fees;

        public override void getDetails() {
            string FullName = this.FirstName + this.LastName;
            Console.WriteLine($"Student Name is {FullName}");
            Console.WriteLine($"Student Age is {this.Age}");
            Console.WriteLine($"Student Contact is {this.Contact}");
            Console.WriteLine($"Student Roll No is {this.RollNo}");
            Console.WriteLine($"Student Fees is {this.Fees}");
        }
    }

    public class Teacher : Person
    {
        public string Qualification;
        public int Salary;

        public override void getDetails()
        {
            string FullName = this.FirstName + this.LastName;
            Console.WriteLine($"Teacher Name is {FullName}");
            Console.WriteLine($"Teacher Age is {this.Age}");
            Console.WriteLine($"Teacher Contact is {this.Contact}");
            Console.WriteLine($"Teacher Qualification No is {this.Qualification}");
            Console.WriteLine($"Teacher Salary is {this.Salary}");
        }
    }
}
