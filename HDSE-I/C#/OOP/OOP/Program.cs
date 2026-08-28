using Aptech;

namespace OOP
{

    public class Car : Program
    {
        //    //Members

        //    // Feilds/Properties
        //    public string brand;
        //    public int year;
        //    public string model;
        //    public string color;

        //    //Constructor (Special type of Function)
        //    public Car(string m, string c, int y, string b)
        //    {
        //        this.model = m;
        //        this.color = c;
        //        this.year = y;
        //        this.brand = b;
        //    }

        //    //Methods/Function/Behaviour
        //    public void run()
        //    {
        //        Console.WriteLine("Toyota Cars run very Fast");
        //    }

        //    public void members()
        //    {
        //        Console.WriteLine($"Car Model is {model}, Color is {color}, Year is {year} and Brand is {brand}");
        //}

        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.center);
        }
    }

    public class Program

    {
        protected string center = "Aptech Learning";

        //static void Main(string[] args)
        //{

            //Console.WriteLine("Hello, World!");

            //Car c = new Car("ABC", "red", 2025, "KIA");
            ////Console.WriteLine(c.brand);
            ////Console.WriteLine(c.year);
            ////Console.WriteLine(c.color);
            ////Console.WriteLine(c.model);
            ////c.run();
            ////c.members();

            //Employee e = new Employee();

            //Console.WriteLine("Enter Your ID");
            //string id = Console.ReadLine();

            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Your City");
            //string city = Console.ReadLine();

            //Console.WriteLine("Enter Your Salary");
            //int salary = int.Parse(Console.ReadLine());

            //e.setter(id, name, city, salary);
            //Console.WriteLine("___________ Employee Details RESULT __________ \n");
            //e.getter();

        //    Program p = new Program();
        //    Console.WriteLine(p.center);

        //}
    }
}
