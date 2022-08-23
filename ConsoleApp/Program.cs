using Generic;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            myList.Add("Ali");
            Console.WriteLine(myList.Length);
            myList.Add("Veli");
            Console.WriteLine(myList.Length);
            myList.Add("Can");
            myList.Add("Deniz");

            Console.WriteLine(myList.Length);

           

            
        }
    }
}
