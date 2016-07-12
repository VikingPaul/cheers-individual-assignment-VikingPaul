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
            Console.WriteLine("WHAT is your name?");
            Console.Write(prompt);
            String name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(chant + "... " + name.Substring(i, 1).ToLower());
            }
            Console.Write(name.ToUpper() + " is... GRAND!");
        }
    }
}
