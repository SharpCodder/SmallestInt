using System;
using System.Collections;
using System.Collections.Generic;

namespace SmallestInt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(345);
            arrayList.Add(3.14);
            arrayList.Add("123");
            arrayList.Add(new List<string>() { "apple", "banana" });

            Console.WriteLine(new SmallestIntService().Get(arrayList));
            Console.ReadLine();
        }
    }
}
