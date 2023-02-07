using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> novbe=new Queue<int>();
            novbe.Enqueue(1);
            novbe.Enqueue(2);   
            novbe.Enqueue(3);
            Console.WriteLine(novbe.Count);
            Console.WriteLine(novbe.Peek());
            Console.WriteLine(novbe.Contains(1));
            Console.WriteLine(novbe.Dequeue());

        }

       
    }
}
