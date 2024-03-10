using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Greet(string name, int age)
        {
            Console.WriteLine("Hello, " + name + ", I heard you are " + age + " years old.");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + ", How are you doing today!");
        }

        static double Average(int a, int b, int c)
        {
            double sum = a + b + c;
            return sum / 3;
        }
        static void Main(string[] args)
        {
            //Greet("Pankaj", 24);
            //Greet("Rohan");
            //Console.WriteLine("The average of your marks is: " + Average(10, 7, 9));

            Player p1 = new Player();
            Console.WriteLine(p1.age);



            //int num = 25;
            //int x = 20;
            //float var = Convert.ToInt32(3.4);
            //Console.WriteLine("the numbs are " + x + " " + var );

            //Console.WriteLine("Hi Pankaj, Welcome to the programming world " + num + " is a number");
            //Console.Write("Pankaj ");
            //Console.Write("Mishra ");
            //Console.Write("is ");
            //Console.Write("good ");
            //Console.Write("boy;");

            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("My name is " + name);

            //Console.WriteLine("How many candies do you want: ");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(can) + 4));


            //Console.WriteLine("How many candies do you want now: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num2 < 20)
            //    Console.WriteLine("You will get 4 more candies " + (num2 + 4));
            //else
            //{
            //    Console.WriteLine("You get 10 less candies" + (num2 - 10));
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Dont be greedy you little piece of cake!!!");
            //}

            //int a = 10;
            //int b = a;
            //Console.WriteLine(b);
            //int c = b;
            //c += 10;
            //Console.WriteLine(c);

            /*Four types of Operators:
                Assignment Operator:
                Logical Operator:
                Comparison Operator:
                Arithmetic Operator:
                Mathematics Operator:*/

            //String Fucntions:

            //string name = "Hi Pankaj Mishra";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(string.Concat(name, ", how are you doing?"));

            //Console.WriteLine(!true);

            //string name = "Pankaj";
            //string candy = "10";
            //string full = $"Hey, how are you doing {name}. I can give you {candy} candies";
            //Console.WriteLine(full);
            ////Console.WriteLine($"Hey, how are you doing {name}. I can give you {candy} candies");
            //Console.WriteLine(full[10]);
            //Console.WriteLine(full[2]);
            //Console.WriteLine(full.IndexOf("is"));
            //Console.WriteLine(full.Substring(3,10));

            //int num = 5;
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int age = 40;
            //switch (age)
            //{
            //    case 40:
            //        Console.WriteLine("You are soon going to enter into Old age category");
            //        break;
            //    case 60:
            //        Console.WriteLine("Congratulations! You have expired the warranty of your life");
            //        break;
            //    case 20:
            //        Console.WriteLine("Great! You are now a youth, go explore and enjoy your life and do coding");
            //        break;
            //    default:
            //        Console.WriteLine("Enter a good number");
            //        break;

            //}

            //int i = 1; 
            //while (true)
            //{
            //    Console.WriteLine("Print False or True based on your decision "+ i);
            //    i++;
            //    //break;//
            //}


            Console.ReadLine();


        }
    }


    class patient
    {
        public string name;
        public int age;
        public doctor theonewhotreatyou;
    }

    class doctor
    {
        public string name;
        public string specialization;
        public int age;
    }
}
