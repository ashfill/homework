using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("hello world");
            int myint = 1492;
            Console.WriteLine(myint);
            string time = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(time);
            Console.WriteLine(date);
            string single = ("x");
            Console.WriteLine(single);
            decimal value = 5.45m;
            Console.WriteLine(value.ToString("c2"));
            string newstring = myint.ToString("Columbus sail the world in 1492");
            Console.WriteLine(newstring);
            Console.WriteLine(value.ToString("I spent $5.45 on a cheeseburger"));
            Console.WriteLine(single.ToString("x marks the spot"));
            Console.ReadLine();
        }

    }
}
