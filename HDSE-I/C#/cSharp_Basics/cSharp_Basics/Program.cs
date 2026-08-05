using System.Collections;
using System.ComponentModel.Design.Serialization;

namespace cSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, World!");
            Console.WriteLine("Hello, World!");

        //Console.WriteLine("Enter Your Name ");
        //var name = Console.ReadLine();
        //Console.WriteLine("Welcome " + name);

        //Console.WriteLine("Enter Your Age ");
        //var age = Console.ReadLine();
        //Console.WriteLine(age);

        //Addition
        //Console.WriteLine("Enter First Number ");
        //var num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Second Number ");
        //var num2 = int.Parse(Console.ReadLine());
        //Console.WriteLine(num1 + num2);

        //Data Types
        //int a = 12;
        //int b = "12";
        //string name2 = "Ali";
        //string city = 123;

        //explicit
        //int age2;
        //age2 = 22;
        //Console.WriteLine(age2);

        //implicit
        //var agee;
        //agee = 12;

        //Explicit DT
        //int salary = 20000;
        //float height = 5.9f;
        //decimal percentage = 76.3M;
        //double cgpa = 3.7;
        //long population = 1234567890L;
        //byte qty = 3;
        //short price = 2200;
        //bool isAllowed = true;

        //string city = "Karachi";
        //char c = 'M';

        //Concatination
        //Console.WriteLine("Enter Your Name ");
        //var name = Console.ReadLine();
        //Console.WriteLine("Welcome " + name);

        //Concatination using Placeholder
        //Console.WriteLine("Enter Your Name ");
        //var name = Console.ReadLine();
        //Console.WriteLine("Enter Your Age ");
        //var ag = Console.ReadLine();
        //Console.WriteLine("Welcome {0}{1}", name, ag);

        //Console.WriteLine("Enter Your Name ");
        //var nam = Console.ReadLine();
        //Console.WriteLine("Enter Your Age ");
        //var ag = Console.ReadLine();
        //Console.WriteLine($"Name is {nam} \nage is {ag}");

        ////Date Methods
        //var date = DateTime.Now;
        //Console.WriteLine(date);
        //Console.WriteLine(DateTime.Now.ToString("yyyy"));
        //Console.WriteLine(DateTime.Now.ToString("yy"));
        //Console.WriteLine(DateTime.Now.ToString("MMMM"));
        //Console.WriteLine(DateTime.Now.ToString("MMMM"));
        //Console.WriteLine(DateTime.Now.ToString("dddd"));
        //Console.WriteLine(DateTime.Now.ToString("ddd"));
        //Console.WriteLine(DateTime.Now.ToString("dd"));


        //------------------------------- Day 2  --------------------------- 

        //Operators 

        //Binary
        //Arithmetic (+, -, 8, /, %, Pow)

        //int num1 = 6;
        //int num2 = 2;
        //Console.WriteLine(num1 + num2);
        //Console.WriteLine(num1 - num2);
        //Console.WriteLine(num1 * num2);
        //Console.WriteLine(num1 / num2);
        //Console.WriteLine(num1 % num2);
        //Console.WriteLine(Math.Pow(num1, num2));


        ////Assignment (=, +=, *=, /=, %=, Pow=)

        //int num11 = 3;
        //int num22 = 7;
        //Console.WriteLine(num11); //3
        //Console.WriteLine(num22); //7

        //Console.WriteLine(num11 += num22); //10

        //Console.WriteLine(num11); //10
        //Console.WriteLine(num22); //7

        //Console.WriteLine(num11 -= num22);
        //Console.WriteLine(num11 *= num22);
        //Console.WriteLine(num11 /= num22);
        //Console.WriteLine(num11 %= num22);
        //Console.WriteLine(Math.Pow(num11, num22));


        //Comparison/Relational Opr (==, <, <=, >, >=, !=)
        //int c1 = 8;
        //int c2 = 9;

        //Console.WriteLine(c1 == c2);
        //Console.WriteLine(c1 < c2);
        //Console.WriteLine(c1 > c2);

        //Logical Opr (&&, ||, !)
        //int l1 = 10;
        //int l2 = 20;

        //Console.WriteLine(l1 > l2 || l1 < l2);
        //Console.WriteLine(l1 > l2 && l1 < l2);
        //Console.WriteLine(!(l1 > l2));



        //// Decision Making Statement/ Conditional Statement
        //string name = "ali";

        ////if 

        //if (name == "faraz")
        //{
        //    Console.WriteLine($"Welcome {name}");
        //}


        //// if - else

        //if (name == "faraz")
        //{
        //    Console.WriteLine($"Welcome {name}");
        //}
        //else
        //{
        //    Console.WriteLine("Welcome Guest");           
        //}

        // Grade Calculator using if-else if (ladder)

        //nested if
        //string mainGate = "close"; 
        //string classDoor = "close";

        //if(mainGate == "open")
        //{
        //    if(classDoor == "open")
        //    {
        //        Console.WriteLine("Welcome Student");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Go Back and Come on Time from next class");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("It's Sunday Today.. Enjoy your day");
        //}

        //Switch Case
        //Console.WriteLine("Search Your Favorite Fruits to Purchase");
        //string fruits = Console.ReadLine();
        //fruits = fruits.ToLower();
        //switch (fruits)
        //{
        //    case "mango":
        //        Console.WriteLine("Mangoes are available right now.");
        //        break;
        //    case "apple":
        //        Console.WriteLine("Apples are available right now.");
        //        break;
        //    case "watermellon":
        //        Console.WriteLine("Watermellon is NOT available right now.");
        //        break;
        //    default:
        //        Console.WriteLine("This Fruits is NOT available right now.");
        //        break;
        //}


        //------------------------------- Day 3  --------------------------- 

        // Loops

        //for
        //while
        //do-while

        //for

        //for(int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"{i}  This is For Loop");
        //}

        //Console.WriteLine("Enter a Number for table");
        //var table = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(table + " X " + i + " = " + table*i);
        //    //Console.WriteLine($"{table} X {i} = {table*i}");
        //}

        //Console.WriteLine("Enter a Number for Testing Even/Odd");
        //var num = int.Parse(Console.ReadLine());

        //if (num % 2 == 0)
        //{
        //    Console.WriteLine("Even Number");
        //}
        //else
        //{
        //    Console.WriteLine("Odd Number");
        //}

        //Nested For
        //for (int i = 1; i <= 10; i++)
        //{
        //    for (int j = 1; j < i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}



        //while
        //int a = 1;
        //while (a <= 10) { 
        //    Console.WriteLine(a);
        //    a++;
        //}

        //int a = 1;
        //while (a < 1)
        //{
        //    Console.WriteLine(a);
        //    a++;
        //}

        ////do-while
        //int b = 1;
        //do
        //{
        //    Console.WriteLine(b);
        //    b++;
        //}
        //while(b < 1);


        //------------------------------- Day 4  --------------------------- 

        //Jump Statements (break, continue, exit, return, goto)

        //break
        //for (int x = 1; x <= 10; x++)
        //{
        //    if (x == 6)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(x);
        //}

        //Console.WriteLine("Hello World");


        //exit
        //for (int x = 1; x <= 10; x++)
        //{
        //    if (x == 6)
        //    {
        //        Environment.Exit(0);
        //    }
        //    Console.WriteLine(x);
        //}

        //Console.WriteLine("Hello World");

        ////continue
        //for (int x = 1; x <= 10; x++)
        //{
        //    if (x == 6)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(x);
        //}

        //go to
        //start:
        //    Console.WriteLine("Enter a Positive Number");
        //    int num = int.Parse(Console.ReadLine());

        //    if (num <= 0)
        //    {
        //        Console.WriteLine("NOT a Positive Number");
        //        goto start;
        //    }

        //    Console.WriteLine($"Number is {num}");



        //    //Run Program Until the user don't not want to close
        //    string ask;
        //    do
        //    {
        //        // Sum of TWO integer values
        //        Console.WriteLine("Enter First Number?");
        //        int num1 = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter Second Number?");
        //        int num2 = int.Parse(Console.ReadLine());

        //        int output = num1 + num2;

        //        Console.WriteLine("Addition of Two Numbers is " + output);  //concat
        //        Console.WriteLine("Do You Want to continue: Yes/No");
        //        ask = Console.ReadLine().ToLower();
        //    }
        //    while (ask == "yes");

        //    Console.WriteLine("Program Exit");



            // ---------------- ARRAY ------------------------

            //One Dimentional

            //Method 1 (Declaration and Initialization both)
            int[] odd_numbers = {1, 3, 5, 7, 9};
            //Console.WriteLine(odd_numbers[0]);
            //Console.WriteLine(odd_numbers[1]);
            //Console.WriteLine(odd_numbers[2]);
            //Console.WriteLine(odd_numbers[3]);
            //Console.WriteLine(odd_numbers[4]);
            //Console.WriteLine(odd_numbers[5]); ////index out of range

            //Method 2 (Declaration)
            int[] even_numbers = new int[4];

            //Initialization
            even_numbers[0] = 8;
            even_numbers[1] = 2;
            even_numbers[2] = 4;

            //Console.WriteLine(even_numbers[0]);
            //Console.WriteLine(even_numbers[1]);
            //Console.WriteLine(even_numbers[2]);
            //Console.WriteLine(even_numbers[3]);

            //for (int i = 0; i < odd_numbers.Length; i++)
            //{
            //    Console.WriteLine(odd_numbers[i]);
            //}

            //foreach (int z in even_numbers)
            //{
            //    Console.WriteLine(z);
            //}



            //Multi Dimentional
            //int[,] matrix = new int[2, 3]
            //{
            //    {1, 2, 3},
            //    {11, 22, 33}
            //};

            //Console.WriteLine(matrix[0,0]);
            //Console.WriteLine(matrix[1, 2]);

            ////print in matrix format
            //for (int i = 0; i < matrix.GetLength(0); i++) // rows
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) // columns
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine(); // Move to next row
            //}

            //foreach (int t in matrix)
            //{
            //    Console.WriteLine(t);
            //}

            //Jagged Array
            //int[][] jagged = new int[3][];  //declaration
            //jagged[0] = new int[] {10, 20 }; //initialization
            //jagged[1] = new int[] {30, 40, 40};  //initialization
            //jagged[2] = new int[] {50, 60, 70, 80};  //initialization
            ////jagged[3] = new int[] {50, 60, 70, 80};

            //Console.WriteLine(jagged[0][0]);
            //Console.WriteLine(jagged[0][1]);
            //Console.WriteLine(jagged[2][2]);
            //Console.WriteLine(jagged[2][2]);

            ////Declaration and Initialization
            //int[][] newJagged = new int[][]
            //    {
            //    new int[] {10},
            //    new int[] {20, 30},
            //    new int[] {40, 50, 60},
            //    new int[] {70, 80, 90, 100},
            //    };

            //Console.WriteLine(newJagged[3][3]);




            // ------- Collection -----------------

            // -------------------  Non-Generic

            //List
            //ArrayList myList = new ArrayList();
            //myList.Add("A");
            //myList.Add("B");
            //myList.Add("C");
            //myList.Add("D");
            //myList.Add(25);
            //myList.Add(true);
            //myList.Add(25.9);

            ////Console.WriteLine(myList[3]);
            //Console.WriteLine(myList.Count);

            //foreach (var alldata in myList)
            //{
            //    Console.WriteLine(alldata);
            //}

            //myList.Remove("D");
            //myList.RemoveAt(2);

            //Console.WriteLine();
            //Console.WriteLine(myList.Count);
            //Console.WriteLine(myList.Contains("A"));
            //Console.WriteLine();

            //foreach (var alldata in myList)
            //{
            //    Console.WriteLine(alldata);
            //}


            ////Stack
            //Stack myStack = new Stack();
            //myStack.Push("Karachi");
            //myStack.Push("Islamabad");
            //myStack.Push("Lahore");
            //myStack.Push("Multan");

            //foreach (string alldata in myStack)
            //{
            //    Console.WriteLine(alldata);
            //}

            //myStack.Pop();
            //Console.WriteLine();

            //foreach (string alldata in myStack)
            //{
            //    Console.WriteLine(alldata);
            //}


            //Hash Table

            //Hashtable myHash = new Hashtable();
            //myHash.Add("Id", 1);
            //myHash.Add("Name", "Ali");
            //myHash.Add("City", "Karachi");
            //myHash.Add("Allowed", false);
            //myHash.Add("Height", 5.9);

            ////Console.WriteLine(myHash["Height"]);

            //foreach (DictionaryEntry hashData in myHash)
            //{
            //    Console.WriteLine(hashData.Key + ": " + hashData.Value);
            //}


            //Sorted List

            //SortedList sl = new SortedList();
            //sl.Add(1, "One");
            //sl.Add(3, "Three");
            //sl.Add(2, "Two");

            //Console.WriteLine(sl[1]);

            //foreach (DictionaryEntry sortedData in sl)
            //{
            //    Console.WriteLine(sortedData.Key + ": " + sortedData.Value);
            //}


            //// -------------------  Generic

            ////List
            //List<string> list = new List<string>();
            //list.Add("Karachi");
            //list.Add("Lahore");
            //list.Add("Islamabad");

            //foreach (string data in list)
            //{
            //    Console.WriteLine(data);
            //}

            ////Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //foreach (int data in stack)
            //{
            //    Console.WriteLine(data);
            //}


            ////Queue
            //Queue<int> even = new Queue<int>();
            //even.Enqueue(2);
            //even.Enqueue(4);
            //even.Enqueue(6);
            //even.Enqueue(8);

            //foreach (int data in even)
            //{
            //    Console.WriteLine(data);
            //}

            //even.Dequeue();

            //foreach (int data in even)
            //{
            //    Console.WriteLine(data);
            //}

            //even.Dequeue();

            //foreach (int data in even)
            //{
            //    Console.WriteLine(data);
            //}

            //Dictionary
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict.Add("Name", "Ali");
            dict.Add("city", "Karachi");
            dict.Add("email", "ali@gmail.com");
            dict.Add("age", 12);
            dict.Add("allowed", true);

            foreach (var data in dict)
            {
                Console.WriteLine(data.Key + ": " + data.Value);
            }
        }
    }
}
