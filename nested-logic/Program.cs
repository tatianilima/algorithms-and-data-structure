using System;

namespace nested_logic
{
    class Program
    {
        //LOCAL LIBRARY
        //book returned on or before expected data - nothing happen
        //if book is returned after date - but still with the same month and year - 
        //----fine 15 hackos * numbers of days late

        //if book is returned after date - but still with the same year - fine = 500 hackos 
        //---fine 500 hackos * numbers of months late

        //if book is returned after year, there are fixed 10000 hackos
        //9 6 2015 - day month year
        static void Main(string[] args)
        {
            string inputDateReturned = "2 6 2009"; //Console.ReadLine();
            string inputDueDate = "5 7 2010";//Console.ReadLine();

            var dateReturned = inputDateReturned.Split(' ');
            var dueDate = inputDueDate.Split(' ');
            bool sameYear = dueDate[2] == dateReturned[2];
            bool sameMonth = dueDate[1] == dateReturned[1];
            
            if (!sameYear)
            {
                int differenceYear = Convert.ToInt32(dateReturned[2]) - Convert.ToInt32(dueDate[2]);
                if(differenceYear < 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine("10000");
                }
            }else if (sameYear && sameMonth)
            {
                int differenceDays = Convert.ToInt32(dateReturned[0]) - Convert.ToInt32(dueDate[0]);
                Console.WriteLine(differenceDays * 15);
            }else if (sameYear & !sameMonth)
            {
                int differenceMonths = Convert.ToInt32(dateReturned[1]) - Convert.ToInt32(dueDate[1]);
                if (differenceMonths < 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(differenceMonths * 500);
                }
            }
        }
    }
}
