using System;
using System.Collections;

/*
 ** Hashtable ** 
Retorna nulo se tentarmos encontrar uma chave que não existe.
É mais lento do que um Dictionary porque requer boxing e unboxing.
Todos os membros de um Hashtable são thread safe.
Não é um tipo genérico. O que significa que não podemos usá-lo com qualquer tipo de dados.

** Dictionary **
Retorna um erro se tentar encontrar uma chave que não existe.
É mais rápido do que um Hashtable porque não há boxing e unboxing.
Somente membros estáticos públicos são thread-safe.
É um tipo genérico, logo podemos usá-lo com qualquer tipo de dados.
*/
namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = GetHashtable();

            //Check if Hashtable contains key or value
            CheckHashtable(ht);
            Console.WriteLine();

            //Show keys/values from Hashtable
            PrintHashTable(ht);
            Console.WriteLine();

            ShowOnlyKeys(ht);
            Console.WriteLine();

            ShowValuesByKey(ht);
            Console.WriteLine();

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
            Console.WriteLine("Contains Key 0001: " + ht.ContainsKey("0001"));
            Console.WriteLine("Contains Value C#: " + ht.ContainsValue("C#"));
            Console.WriteLine("Contains Value PHP: " + ht.ContainsValue("PHP"));
            Console.WriteLine("Contains 0002: " + ht.Contains("0002")); //search only by Key
        }

        static void PrintHashTable(Hashtable ht)
        {
            foreach (DictionaryEntry element in ht)
            {
                string id = (string)element.Key;
                string language = (string)element.Value;
                Console.WriteLine("Id: {0}, Language: {1}", id, language);
            }
        }

        static void ShowOnlyKeys(Hashtable ht)
        {
            
            foreach (var key in ht.Keys)
            {
                Console.WriteLine("Keys : " + key);
            }
        }

        static void ShowValuesByKey(Hashtable ht)
        {
            ICollection keys = ht.Keys;
            foreach (String k in keys)
            {
                Console.WriteLine("Values: " + ht[k]);
            }

        }

        static void RemoveElement(Hashtable ht)
        {
            ht.Remove("0004");
            Console.WriteLine("After remove, contains Python: " + ht.ContainsValue("Python"));
        }

        static void RemoveAllElements(Hashtable ht)
        {
            ht.Clear();
            Console.WriteLine("After remove all, contains Python: " + ht.ContainsValue("Python"));
        }
    }
}
