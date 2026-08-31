using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{

    //Implicit Interface
    public interface IVehicle
    {
        void start();
        void stop();
    }

    public class Bus : IVehicle
    {
        public void start()
        {
            Console.WriteLine("Bus is running!");
        }

        public void stop()
        {
            Console.WriteLine("Bus is Stopping!");
        }

    }

    public class Container : IVehicle
    {
        public void start()
        {
            Console.WriteLine("Container is running!");
        }

        public void stop()
        {
            Console.WriteLine("Container is Stopping!");
        }

    }



    //Explicit Interface
    public interface IPrinter
    {
        void print();
    }
    public interface IScanner
    {
        void print();
    }

    public class MultiFunctionDevice : IPrinter , IScanner
    {
        void IPrinter.print()
        {
            Console.WriteLine("Printer is Printing...");
        }

        void IScanner.print()
        {
            Console.WriteLine("Scanner is Scanning...");
        }
    }


    //interface inheritance
    public interface Inter1
    {
        void output1();
    }

    public interface Inter2
    {
        void output2();
    }

    public interface Inter3 : Inter1 , Inter2
    {
        void output3();
    }

    public class PrintMethod : Inter3
    {
        public void output1 ()
        {
            Console.WriteLine("This is a Method of Interface 1");
        }
        public void output2 ()
        {
            Console.WriteLine("This is a Method of Interface 2");
        }
        public void output3 ()
        {
            Console.WriteLine("This is a Method of Interface 3");
        }
    }
}
