using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    //// --- Single Level Inheritance -------------
    //public class Animal
    //{
    //    protected string name;

    //    public void eat()
    //    {
    //        Console.WriteLine("Cat eat meat");
    //    }
    //}

    //public class Cat : Animal
    //{

    //    void run()
    //    {
    //        Console.WriteLine("Cat can run");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");

    //        Cat c = new Cat();
    //        c.run();
    //        c.eat();
    //        c.name = "Mishi";
    //    }
    //}



    // ---------- Multi Level Inheritance ----------------
    //public class Animal
    //{
    //    protected string name;

    //    public void eat()
    //    {
    //        Console.WriteLine("Cat eat meat");
    //    }
    //}

    //public class Percian : Animal
    //{
    //    public void speak()
    //    {
    //        Console.WriteLine("Cat eat speak");
    //    }
    //}

    //public class Cat : Percian
    //{

    //    void run()
    //    {
    //        Console.WriteLine("Cat can run");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");

    //        Cat c = new Cat();
    //        c.run();
    //        c.eat();
    //        c.name = "Mishi";
    //        c.speak();
    //    }
    //}


    // ---------- Heirarchical Inheritance ----------------

    public class Vehicle
    {
        string reddNo;

        public void run()
        {
            Console.WriteLine("Vehicle can run");
        }
    }

    public class Bike : Vehicle
    {
        public void ride()
        {
            Console.WriteLine("Two Wheeler can ride");
        }
    }

    public class Car : Vehicle
    {
        public void drive()
        {
            Console.WriteLine("Four Wheeler can drive");
        }
    }

    public class EV : Bike
    {
        public void newone()
        {
            Console.WriteLine("EV Bike runs by consuming battery power");
        }
    }

    public class China : Bike
    {
        public void oldone()
        {
            Console.WriteLine("China Bike runs by consuming fuel");
        }
    }

    public class Hybrid : Car
    {
        public void newone()
        {
            Console.WriteLine("Hybrid Cars runs by consuming Battery Power");
        }
    }
}
