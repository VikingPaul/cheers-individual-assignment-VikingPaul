using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String prompt = "> ";
            String chant = "Give me a";
            String vowel = "aeiolnfshrmx";
            DateTime today = DateTime.Now;
            Console.WriteLine("WHAT is your name?");
            Console.Write(prompt);
            String name = Console.ReadLine();
            Console.WriteLine("WHAT is your birthday? (mm/dd)");
            Console.Write(prompt);
            String birthday = Console.ReadLine();
            birthday = birthday + "/" + Convert.ToString(today.Year+1);
            int Bdate = DateTime.Parse(birthday).DayOfYear;
            int Tdate = today.DayOfYear;
            for (int i = 0; i < name.Length; i++)
            {
                if (vowel.Contains(name.Substring(i, 1).ToLower()))
                {
                    Console.WriteLine(chant + "n... " + name.Substring(i, 1).ToLower());
                }
                else
                {
                    Console.WriteLine(chant + "... " + name.Substring(i, 1).ToLower());
                }
            }
            Console.WriteLine(name.ToUpper() + " is... GRAND!");


            if (Bdate == Tdate)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else
            {
                int days;
                if (Bdate > Tdate)
                {
                    days = Bdate-Tdate;
                }
                else
                {
                    days = 366-Tdate+Bdate;
                }

                Console.WriteLine("Your Birthday is " + days + " day(s) away!");
            }
        }
    }
}
