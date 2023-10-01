using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Employe
    {
        string name, address;
        int id, salary;
        static int count = 0;
        public Employe(string name,string address,int id,int salary)//constructor
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.salary = salary;
            count++;
        }
        static Employe()//static constructor only one time initialize even if we created many object it will onely invoke one time
        {
            Console.WriteLine("obeject created");
        }
        ~Employe()//destructor
        {
            Console.WriteLine("obeject destrected");
        }
        public void show()//need an object to access the class
        {
            Console.WriteLine($"number of object created : {count} \nname : {name}\n" +
                $"id : {id}\n" +
                $"address : {address}\nsalary : {salary}");
        }
        public static int coun()//no object need to create to access the method
        {
            return count;
        }
    }
    public static class emp//static class no need to create object to use them
    {
        public static int id = 6;
        public static string name = "kris";
        public static void fun()
        {
            Console.WriteLine($"id : {id} \n name : {name}");
        }
    }
    public struct rectange//struct
    {
        int width, height;
        public rectange(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        public void area()
        {
            Console.WriteLine($"area of rectange = {width * height}");
        }
    }

    public enum day{mon,tue,wed,thu,fri,sat,sun=9}//enum

    internal class Program
    {
        static void Main(string[] args)
        {
            //public class
            Employe em1 = new Employe("krish", "chennai", 1, 20000);
            Employe em2 = new Employe("krish", "chennai", 2, 20000);
            em1.show();
            em2.show();
            Console.WriteLine(Employe.coun() + emp.id + " " + emp.name );
            //static class
            emp.fun();
            //struct
            rectange rec = new rectange(5, 6);
            rec.area();
            //enum
            int x = (int)day.sun;
            Console.WriteLine("sun = {0}", x);
            foreach (string s in Enum.GetNames(typeof(day)))
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
