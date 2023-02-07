using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list1 = new List<int>();
            //list1.Add(1);
            //list1.Add(222);
            //list1.Add(02);

            List<string> cities = new List<string>();   
            cities.Add("Baku");
            cities.Add("Istanbul");
            List<string> favcities = new List<string>();
            favcities.Add("Oslo");
            favcities.Insert(1, "Paris");

            favcities.AddRange(cities);
          

            //foreach (var item in favcities)
            //{
            //    Console.WriteLine(item);



            //}
            Console.WriteLine(favcities.Contains("Oslo"));



        }
    }
}
