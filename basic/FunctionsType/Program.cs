using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsType
{
    internal class Program
    {
        public void Fn(int n)
        {
            Console.WriteLine(n);
        }
        static void Fun(string a)
        {
            Console.WriteLine(a);
        }
        static int add(int a,int b)
        {
            return a + b;
        }
        static void Funref(ref int a)
        {
            a = 10;
        }
        static void FunOu(out int a)
        {
            a = 100;
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            n.Fn(10);//function need to create an objec to access
            Fun("dfgfg");//function call by value
            Console.WriteLine($"addition of 5 + 8 = {add(5, 8)}");//return type function
            int a = 90;
            Console.WriteLine(a);
            Funref(ref a);//call by referrence 
            Console.WriteLine(a);
            FunOu(out a);//function with out parameter
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
