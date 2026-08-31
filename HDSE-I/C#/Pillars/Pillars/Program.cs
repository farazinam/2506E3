namespace Pillars
{

    public class Program : MethodOverriding
    {

        public override void Greet()
        {
            Console.WriteLine("Hello Greet Function 2 (Child)");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Japanese j = new Japanese();
            //j.drive();
            //j.oldone();
            //j.run();


            //MethodOverloading mo = new MethodOverloading();
            //mo.Add();
            //mo.Add("Faraz");
            //mo.Add(6,8);
            //mo.Add("Faraz","Inam");
            //mo.Add("Faraz",1);
            //mo.Add(1, "Faraz");
            //Console.WriteLine(mo.Add(23));

            //MethodOverriding mo2 = new MethodOverriding();
            //mo2.Greet();

            //Program p = new Program();
            //p.Greet();

            //Encapsulation e = new Encapsulation();
            //Console.WriteLine("Enter Your Pin");
            //int getpin = int.Parse(Console.ReadLine());
            //e.setter(getpin);
            //e.getter();

            //BankAccount ba = new BankAccount();
            //ba.getbalance();

            //ba.deposit(1000);
            //ba.getbalance();

            //ba.deposit(1500);
            //ba.getbalance();

            //Console.WriteLine("Enter Your Name");
            //string ownername = Console.ReadLine();

            //Console.WriteLine("Enter Your Account Number");
            //int acno = int.Parse(Console.ReadLine());

            //Meezan m = new Meezan(1000, acno, ownername);

            //m.balaceEnquiry();
            //m.getOwnerName();
            //m.getAccountNo();

            //Console.WriteLine("Enter Amount to deposit");
            //int dep = int.Parse(Console.ReadLine());
            //m.deposit(dep);

            //m.balaceEnquiry();

            //Console.WriteLine("Enter Amount to WithDrawl");
            //int wid = int.Parse(Console.ReadLine());
            //m.withdrawl(wid);

            //m.balaceEnquiry();


            //Abstraction p = new Abstraction();
            //p.employee(123, "Ahsan", 55000);
            //p.EmployeeDetails();

            //Dog d = new Dog();
            //d.makeSound();

            //Student s = new Student();
            //s.FirstName = "Muhammad";
            //s.LastName = "Ahmed";
            //s.Age = 22;
            //s.Contact = "03006573645";
            //s.RollNo = "123";
            //s.Fees = 7500;

            //Console.WriteLine("\n _________Student Details__________ \n");
            //s.getDetails();

            //Teacher t = new Teacher();
            //t.FirstName = "Muhammad";
            //t.LastName = "Ahmed";
            //t.Age = 22;
            //t.Contact = "03006573645";
            //t.Qualification = "Bachelors";
            //t.Salary = 12000;

            //Console.WriteLine("\n _________Teacher Details__________ \n");
            //t.getDetails();


            //Console.WriteLine("\n _________Bus Details__________ \n");
            //Bus b = new Bus();
            //b.start();
            //b.stop();

            //Console.WriteLine("\n _________Container Details__________ \n");
            //Container c = new Container();
            //c.start();
            //c.stop();


            //MultiFunctionDevice mfd = new MultiFunctionDevice();
            //IPrinter printer = mfd;
            //printer.print();

            //IScanner scanner = mfd;
            //scanner.print();

            //PrintMethod pm = new PrintMethod();
            //pm.output1();
            //pm.output2();
            //pm.output3();



            // --------------- Exception Handling ------------------
            //without label
            try
            {
                Console.WriteLine("Enter a Number");
                decimal num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Enter another Number");
                decimal num2 = int.Parse(Console.ReadLine());
                decimal output = num1 / num2;
                Console.WriteLine(output);
            }
            catch
            {
                Console.WriteLine("Denomintaor Should be non Zero");
            }


            //with label
            //try
            //{
            //    Console.WriteLine("Enter a Number");
            //    decimal num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("\n Enter another Number");
            //    decimal num2 = int.Parse(Console.ReadLine());
            //    decimal output = num1 / num2;
            //    Console.WriteLine(output);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Denomintaor Should be non Zero \n" + ex.ToString());
            //}

            // 
            //try
            //{
            //    int[] arr = new int[2];
            //    arr[0] = 10;
            //    arr[1] = 20;
            //    arr[2] = 30;
            //    Console.WriteLine(arr[0]);
            //    Console.WriteLine(arr[1]);
            //    Console.WriteLine(arr[2]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }


}
    
}
