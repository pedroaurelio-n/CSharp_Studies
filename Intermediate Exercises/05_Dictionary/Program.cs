using System;
using System.Collections.Generic;

namespace _05_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictNameAge = new Dictionary<string, int>();

            dictNameAge.Add("Pedro", 20);
            dictNameAge.Add("Tony", 15);
            dictNameAge.Add("Lalo", 34);

            dictNameAge["Snake"] = 22;

            dictNameAge.Add("Hero", 50);

            string[] arrName = new string[dictNameAge.Keys.Count];
            int[] arrAge = new int[dictNameAge.Values.Count];

            dictNameAge.Keys.CopyTo(arrName, 0);
            dictNameAge.Values.CopyTo(arrAge, 0);

            for (int i = 0; i < dictNameAge.Count; i++)
            {
                Console.WriteLine($"Name: {arrName[i]} / Age: {arrAge[i]}");
            }

            if (dictNameAge.ContainsKey("Legaia"))
            {
                dictNameAge.Add("Legaia", 70);
            }

            if (dictNameAge.ContainsValue(20))
            {
                dictNameAge.Add("Test2", 20);
            }

            Console.WriteLine();

            arrName = new string[dictNameAge.Keys.Count];
            arrAge = new int[dictNameAge.Values.Count];

            dictNameAge.Keys.CopyTo(arrName, 0);
            dictNameAge.Values.CopyTo(arrAge, 0);

            for (int i = 0; i < dictNameAge.Count; i++)
            {
                Console.WriteLine($"Name: {arrName[i]} / Age: {arrAge[i]}");
            }

            Console.WriteLine();

            if (dictNameAge.TryGetValue("Lalo", out int try1))
            {
                Console.WriteLine($"Could get {try1}");
            }

            if (dictNameAge.TryGetValue("Legaia", out int try2))
            {
                Console.WriteLine($"Could get {try2}");
            }

            Console.ReadKey();
        }
    }
}
