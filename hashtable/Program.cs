using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            
            //How to add items on hashtable. Example: ht.Add("key", "value");
            ht.Add("0001", "C#");
            ht.Add("0002", "Java");
            ht.Add("0003", "Golang");
            ht.Add("0004", "Python");

            ICollection keys = ht.Keys;
            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }

            //Searching some word 
            Console.WriteLine(ht.ContainsKey("0001"));
            Console.WriteLine(ht.ContainsValue("C#"));
            Console.WriteLine(ht.ContainsValue("PHP"));

            //Remove elements from Hashtable
            ht.Remove("Python");
            Console.WriteLine(ht.ContainsValue("Python"));
            ht.Clear(); //remove all elements

            Console.ReadLine();
        }
    }
}
