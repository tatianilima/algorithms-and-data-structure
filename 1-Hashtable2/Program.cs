using System;
using System.Collections;
using System.Linq;

//https://www.hackerrank.com/challenges/30-dictionaries-and-maps/leaderboard
namespace _1_Hashtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Hashtable contacts = new Hashtable();

            //get contact numbers
            for (int i = 0; i < n; i++)
            {
                //add contacts on list
                string[] contact = Console.ReadLine().Split(' ');
                if (contact.Count() > 1)
                {
                    contacts[contact[0]] = contact[1];
                }
            }

            //get names should be search
            string name;
            while ((name = Console.ReadLine()) != null)
            {
                if (contacts.Contains(name))
                {
                    Console.WriteLine(name + "=" + contacts[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
