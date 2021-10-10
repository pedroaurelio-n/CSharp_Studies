using System;
using System.Collections;

namespace _03_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("test1");
            arrayList.Add(50);
            arrayList.Add('a');
            arrayList.Add(54.9f);
            arrayList.Add(true);

            foreach(var value in arrayList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            arrayList.Remove(50);
            arrayList.Insert(1, 51);
            arrayList.Add(false);
            arrayList.Reverse();

            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
