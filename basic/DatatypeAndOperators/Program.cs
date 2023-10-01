using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeAndOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.input and output codes
            Console.WriteLine("\nhello program");//print something in new line
            Console.Write("\thelo\b end");//print things in same line

            Console.WriteLine(Console.ReadLine());//get user input as string
            Console.WriteLine("Enter a char to get decimal value : ");
            Console.WriteLine("Entered value: " + Console.Read());//it will read the char convert into int
            Console.WriteLine(Convert.ToChar(Console.Read()));// it will convert int into char
            */

            /*
            //2.data types
            int a = -2;short _b = 3;long c = 4;//integers with signed values
            ushort d = 4;ulong e = 5; uint f = 6;//integers with only positive values
            char g = 'g';string h = "heloo";//Srting and characters
            float i = 23.0F; double j = 45.978D;//decimal points value
            bool z = true;//boolean type(true or false)
            Console.WriteLine(z.GetType());//method to identify type of variable
            */

            /*
            //3.operators
            //3.1Binary Operators
            //3.1.1 arithmetic operators
            int a = (1+2-3*(2+2)/2%1);
            //3.1.2 relational operator
            bool b = (2!=3);//>,<,==,>=,<=,!=
            //3.1.3 logical operator
            bool c = !((3!=4) || (4!=4));// &&,||,!
            //3.1.4 bitwise operator
            int d = 1 | 0;//&,|,>>,<<,~,^
            //3.1.5 assignment operator
            d += 1;//+=,-=,%=,/=,*=,=
            //3.2 unary operator
            d++;++d; //++,--
            //3.3 terniary operator
            string g = (2 < 5) ? "lesss" : "graet";//condition true statement false statement
            Console.WriteLine(g);
            */

            /*
            //4 Console.WriteLine different ways of writing
            string a = "kris";
            Console.WriteLine("heloo i am "+a);// Concatenation Method (from VB days)
            Console.WriteLine("heloo i am {0}",a); // Format Method (from C days)
            Console.WriteLine($"heloo i am {a}");// Interpolation Method- Req. C# 6 or later [Cleanest]
            */
            Console.ReadKey();//wating for receive prees any key to continue
        }
    }
}
