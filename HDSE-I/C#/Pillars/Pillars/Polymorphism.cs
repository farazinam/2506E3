using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    internal class MethodOverloading
    {
        public void Add()
        {
            Console.WriteLine(2 + 5);
        }
        public void Add(string name)
        {
            Console.WriteLine(name);
        }

        public int Add(int number)
        {
            return number;
        }

        public void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public void Add(string fn, string ln)
        {
            Console.WriteLine(fn + ln);
        }
        public void Add(string fn, int num)
        {
            Console.WriteLine(fn + num);
        }
        public void Add(int num, string fn)
        {
            Console.WriteLine(num + fn);
        }
    }

    public class MethodOverriding
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello Greet Function 1 (Parent)");
        }

    }



}
