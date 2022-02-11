using System;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> rehber = new Dictionary<int, string>();

            rehber.Add(1,"Ahmet Korkmaz");
            rehber.Add(12, "Mustafa Yılmaz");
            rehber.Add(82, "Emre Akın");
            rehber.Add(28, "Üzeyir Ataç");
            rehber.Add(66, "Samet Tüzüner");

            
            Console.WriteLine("*** Dizinin Elemanlarına Erişim ***");
            
            Console.WriteLine(rehber[28]);

            foreach (var item in rehber)
                Console.WriteLine(item);

            Console.WriteLine("*** Count ***");
            Console.WriteLine(rehber.Count);

            Console.WriteLine("*** Contains ***");
            Console.WriteLine(rehber.ContainsKey(61));
            Console.WriteLine(rehber.ContainsValue("Samet Tüzüner"));

            Console.WriteLine("*** Remove ***");
            rehber.Remove(1);

            Console.WriteLine("*** Keys ***");
            foreach (var item in rehber.Keys)
                Console.WriteLine(item);

            Console.WriteLine("*** Values ***");
            foreach (var item in rehber.Values)
                Console.WriteLine(item);

        }
    }
}
