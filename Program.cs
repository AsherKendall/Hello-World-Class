using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    public class Functions
    {
        public static void PrintMenu()
        {
            Console.Write("\n1: Select Random Number 1-10\n" +
                    "2: Print Current Date in ShortDate format\n" +
                    "3: Sort and print random Name of 10 Dinos\n" +
                    "4: Random String Manipulation\n\n");
        }

        public static int RandomNumber()
        {
            var rand = new Random();
            int num = rand.Next(1, 11);
            return num;
        }

        public static string PrintDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        public static string RandomDinoSort()
        {

            List<string> dinos = new List<string>()
                    {
                        "Hypacrosaurus",
                        "Aeolosaurus",
                        "Zanabazar",
                        "Alamosaurus",
                        "Nuthetes",
                        "Szechuanosaurus",
                        "Torvosaurus",
                        "Vulcanodon",
                        "Acrotholus",
                        "Pampadromaeus",
                    };

            var finalres = dinos.OrderBy(n => n).ToList<string>();


            var rand = new Random();
            int num = rand.Next(0, 10);
            return finalres[num].ToString() + " index " + num;
        }

        public static string RandomStringManipulation(string str1)
        {
            var rand = new Random();
            int num = rand.Next(0, 10);
            string NewString = "";

            if (num == 0)
            {
                string str = str1;
                var t = str.Contains("es");
                if (t)
                {
                    Console.WriteLine("String Contains es");
                }
                else
                {
                    Console.WriteLine("String Doesn't Contain es");
                }

            }
            if (num == 1)
            {
                string str = str1;
                var x = str.Split(' ');
                foreach (string i in x)
                {
                    NewString += i + '\n';
                }
            }
            if (num == 2)
            {
                string str = str1;
                var x = str.Replace('e', 'a');
                NewString = x;
            }
            if (num == 3)
            {
                string str = str1;
                var x = String.Join("bruh", str);
                NewString = x;
            }
            if (num == 4)
            {
                string str = str1;
                var x = new string(str.ToCharArray().Reverse().ToArray());
                NewString = x;
            }
            if (num == 5)
            {
                string str = str1;
                var l = str.ToCharArray();
                var x = from s in l orderby s select s;
                NewString = new string(x.ToArray());
            }
            if (num == 6)
            {
                string str = str1;
                var l = str.ToCharArray();
                var x = from s in l where s == 'e' select s;
                NewString = new string(x.ToArray());
            }
            if (num == 7)
            {
                string str = str1;
                var l = str.Split();
                string x = "";
                foreach (string i in l)
                {
                    x += " " + new string(i.ToCharArray().Reverse().ToArray());
                }
                NewString = new string(x.ToArray());
            }
            if (num == 8)
            {
                string str = str1;
                var x = str.ToUpper();
                NewString = x;
            }
            if (num == 9)
            {
                string str = str1;
                var x = str.ToCharArray().Distinct().ToArray();
                NewString = new string(x);
            }
            return NewString;
        }

    }
    internal class Program
    {
        


        static void Main(string[] args)
        {
            while (true)
            {
                
                Functions.PrintMenu();
                string menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                {
                    Console.WriteLine(Functions.RandomNumber());
                } else if(menuSelect == "2")
                {
                    Console.WriteLine(Functions.PrintDate());
                }
                else if (menuSelect == "3")
                {
                    Console.WriteLine(Functions.RandomDinoSort());

                }
                else if (menuSelect == "4")
                {
                    Console.Write("Enter a string: ");
                    string str1 = Console.ReadLine();
                    Console.WriteLine(Functions.RandomStringManipulation(str1));
                }
                else
                {
                    Console.WriteLine("Try Again.");
                }
            }

        }
    }
}
