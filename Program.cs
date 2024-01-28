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
                Console.WriteLine("3: Sort and print random Name of 10 Dinos");
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
                    Console.WriteLine(finalres[num] + " index " + num);

                }
                else if (menuSelect == "4")
                {
                    var rand = new Random();
                    //int num = rand.Next(0, 10);
                    int num = 0;
                    Console.Write("Enter a string: ");
                    string str1 = Console.ReadLine();

                    if (num == 0)
                    {
                        string str = str1;
                        var t = str.Contains("es");
                        if(t)
                        {
                            Console.WriteLine("String Contains es");
                        }else
                        {
                            Console.WriteLine("String Doesn't Contain es");
                        }
                        
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var x = str.Split(' ');
                        foreach(string i in x)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var x = str.Replace('e', 'a');
                        Console.WriteLine(x);
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var x = String.Join("bruh", str);
                        Console.WriteLine(x);
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var x = new string(str.ToCharArray().Reverse().ToArray());
                        Console.WriteLine(x);
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var l = str.ToCharArray();
                        var x = from s in l orderby s select s;
                        Console.WriteLine(new string(x.ToArray()));
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var l = str.ToCharArray();
                        var x = from s in l where s=='e' select s;
                        Console.WriteLine(new string(x.ToArray()));
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var l = str.Split();
                        string x = "";
                        foreach(string i in l)
                        {
                            x += " " + new string(i.ToCharArray().Reverse().ToArray());
                        }
                        Console.WriteLine(new string(x.ToArray()));
                    }   
                    if (num == 0)
                    {
                        string str = str1;
                        var x = str.ToUpper();
                        Console.WriteLine(x);
                    }
                    if (num == 0)
                    {
                        string str = str1;
                        var x = str.ToCharArray().Distinct().ToArray();
                        Console.WriteLine(new string(x));
                    }
                }
                else
                {
                    Console.WriteLine("Try Again.");
                }
            }

        }
    }
}
