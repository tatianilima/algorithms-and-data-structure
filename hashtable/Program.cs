using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = GetHashtable();

            //Check if Hashtable contains key or value
            CheckHashtable(ht);

            //Show keys/values from Hashtable
            ShowOnlyKeys(ht);
            ShowValuesByKey(ht);

            //Remove elements from Hashtable
            RemoveElement(ht);

            //remove all elements
            RemoveAllElements(ht);

            Console.ReadLine();
        }

        static Hashtable GetHashtable()
        {
            Hashtable ht = new Hashtable();

            //How to add items on hashtable. Example: ht.Add("key", "value");
            ht.Add("0001", "C#");
            ht.Add("0002", "Java");
            ht.Add("0003", "Golang");
            ht.Add("0004", "Python");

            return ht;
        }

        static void CheckHashtable(Hashtable ht)
        {
            Console.WriteLine(ht.ContainsKey("0001"));
            Console.WriteLine(ht.ContainsValue("C#"));
            Console.WriteLine(ht.ContainsValue("PHP"));
            Console.WriteLine(ht.Contains("Java"));
        }

        static void ShowOnlyKeys(Hashtable ht)
        {
            
            foreach (int key in ht.Keys)
            {
                Console.WriteLine("Keys : " + key);
            }
        }

        static void ShowValuesByKey(Hashtable ht)
        {
            ICollection keys = ht.Keys;
            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }

        }

        static void RemoveElement(Hashtable ht)
        {
            ht.Remove("Python");
            Console.WriteLine(ht.ContainsValue("Python"));
        }

        static void RemoveAllElements(Hashtable ht)
        {
            ht.Clear();
            Console.WriteLine(ht.ContainsValue("Python"));
        }
    }
}
