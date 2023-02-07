using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> Data = new SortedList<string, int>();
            {
                Data.Add("Samir",17);
                Data.Add("Tebriz", 29);
                Console.WriteLine(Data.ContainsValue(17));
                

            };

           
        }
    }
}
