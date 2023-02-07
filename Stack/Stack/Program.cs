using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack  <int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            //foreach (var item in numbers)
            //{

            //    Console.WriteLine(item);
            //}
         
            Console.WriteLine(numbers.Peek());
         
            //Console.WriteLine(numbers.Contains(5));
        }
    }
}
