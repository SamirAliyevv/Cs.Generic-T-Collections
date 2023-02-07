using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> GroupInfo = new Dictionary<string, string>();
            GroupInfo.Add("Aliyev Samir", "Programmer");
            GroupInfo["Aliyev Samir"]= "Front-End";
            foreach (var item in GroupInfo)
            {
                Console.WriteLine(item);
            }
             
             
        }
    }
}
