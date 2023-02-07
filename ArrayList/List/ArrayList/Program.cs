using System;
using System.Collections;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ArrayCar = new ArrayList();
            ArrayCar.Add(1);
            ArrayCar.Add(4.5);
            ArrayCar.Add("A");
            ArrayCar.Add("Samir");


            ArrayCar[2] = "Elcin";

            //foreach (var item in ArrayCar)
            //{
            //    Console.WriteLine(item);
            //}
            ArrayList ArrayCar2 = new ArrayList();
            {

                ArrayCar2.Add(12);
                ArrayCar2.Add("Omer");

            }

            ArrayCar.InsertRange(3, ArrayCar2);
            //foreach (var item in ArrayCar)
            //{

            //    Console.WriteLine(item);
            //}
            //ArrayCar.Remove(4.5);
            //foreach (var item in ArrayCar)
            //{
            //    Console.WriteLine(item);

            //    //}
            //    ArrayCar.RemoveAt(1);
            //foreach (var item in ArrayCar)
            //{
            //    Console.WriteLine(item);
            //}
            //ArrayCar.RemoveRange(0,2);
            //Console.WriteLine(ArrayCar.Contains("Elcin"));
            
            
            






        } 
    }
}
