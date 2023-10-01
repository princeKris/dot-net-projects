using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysType
{
    internal class Program
    {
        static void Show(params object[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        static void Main(string[] args)
        {
            //single dimensional array
            //int[] ar = new int[10];
            //ar[1] = 1;
            //int[] arr=new int[10] {1,2,3,4,5,6,8,5,5,5};
            //int[] ary = { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            //foreach (int a in ary)
            //{
            //    Console.WriteLine(a);
            //}

            //int[,] ary = { { 1, 2 }, { 3, 4 } };//2d array
            //int[,,] ay = { { { 1, 2, 3 }}};//3d array
            //foreach (int a in ay)
            //{
            //    Console.WriteLine(a);
            //}

            ////Jagged Array
            //int[][] arr = new int[2][];// Declare the array  
            //arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
            //arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };
            //foreach (int a in arr[0])
            //{
            //    Console.WriteLine(a);
            //}

            //Show(1,2,3,"hii",'d');//Params array
            Console.ReadKey();
        }
    }
}
