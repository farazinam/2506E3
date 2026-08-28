using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
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


}
