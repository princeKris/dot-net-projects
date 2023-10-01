using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Control statement
        /*
        //1 if else if else 
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("if block");
        }else if (a == 2)
        {
            Console.WriteLine("else if block");
        }
        else
        {
            if(a == 3)
            {
                Console.WriteLine("nested if");
            }
            Console.WriteLine("else block");
        }
        */

        /*
        //2. Switch case
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case(50):
                Console.WriteLine("pass");
                break;
            case 60:
                Console.WriteLine("E gade");
                break;
            case 70:
                Console.WriteLine("D gade");
                break;
            case 80:
                Console.WriteLine("C gade");
                break;
            case 90:
                Console.WriteLine("B gade");
                break;
            case 1000:
                Console.WriteLine("A gade");
                break;
            default:
                Console.WriteLine("not 50,60,70,80,90 and 100");
                break;
        }*/

        //3 forloop
        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine($"{i}*2={i * 2}");
        //}
        //for (; ; )
        //{
        //    Console.WriteLine("infine loop");
        //}

        //To comment a selection use ctrl+k+c and to uncomment the selection use ctrl+k+u .
        //4 foreach
        //string a = "hekloo i am kris";
        //foreach(char i in a)
        //{
        //    Console.WriteLine(i);
        //}

        //5 while loop
        //int i =0;
        //while (i <= 10)
        //{
        //    Console.WriteLine($"{i}*3={i*3}");
        //    ++i;
        //}
        //while (true)
        //{
        //    Console.WriteLine("infinet loop");
        //}

        //6 do while
        //int i = 0;
        //do
        //{
        //    Console.WriteLine($"{i}*3={i * 3}");
        //    i++;
        //} while (i <= 20);

        //7 goto
        //int i = 0;
        //Hi:
        //    Console.WriteLine($"{i}*3={i * 3}");
        //if (++i <= 10)
        //{
        //   goto Hi;
        //}

        //8 break continue
        //int i=0;
        //while (true) {
        //        Console.WriteLine("break ");
        //        if (i == 1)
        //        {
        //            Console.WriteLine("continue");
        //        }
        //        else
        //        {
        //            i++;
        //            break;
        //        }
        //}


            Console.ReadKey();
        }
    }
}
