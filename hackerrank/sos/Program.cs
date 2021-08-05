using System;
using System.Linq;
using System.Text;

//https://www.hackerrank.com/challenges/mars-exploration/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
namespace sos
{
    class Program
    {
        static void Main(string[] args)
        {
            string marsMessage = "SOSSOS";

            var errors = 0;
            var s = marsMessage.ToCharArray();
            for (int i = 0; i < s.Count(); i++)
            {
                //the amount of letters per word is 3
                if(i % 3 == 0 && s[i] != 'S')
                {
                    errors += 1;
                }

                if (i % 3 == 1 && s[i] != 'O' )
                {
                    errors += 1;
                }

                if (i % 3 == 2 && s[i] != 'S')
                {
                    errors += 1;
                }
            }
            Console.WriteLine(errors);

            Console.ReadLine();
        }

    }
}
