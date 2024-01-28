using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(); //New Line
                Console.WriteLine("1: Select Random Number 1-10");
                Console.WriteLine("2: Print Current Date in ShortDate format");
                Console.WriteLine("3: ");
                Console.WriteLine("4: ");
                Console.WriteLine(); //New Line

                string menuSelect = Console.ReadLine();
                


                if (menuSelect == "1")
                {
                    var rand = new Random();
                    int num = rand.Next(1,11);
                    Console.WriteLine(num);
                } else if(menuSelect == "2")
                {
                    Console.WriteLine(DateTime.Now.ToShortDateString());
                }
                else if (menuSelect == "3")
                {

                }
                else if (menuSelect == "4")
                {

                }else
                {
                    Console.WriteLine("Try Again.");
                }
            }

        }
    }
}
