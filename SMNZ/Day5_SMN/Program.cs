using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5_SMN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char word;
            List<string> City = new List<string>();
            City.Add("Aung Pan");
            City.Add("Kalaw");
            City.Add("Mandalay");
            City.Add("Magway");
            City.Add("Lwai Kaw");
            City.Add("Myitkyina");
            City.Add("Thar Si");
            City.Add("Sagaing");
            City.Add("Kume");
            City.Add("Muse");


            a: Console.WriteLine("Type \"1\" if you want to know StartWord...\n Type \"2\" if you want to know EndWord...");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("Enter a character 'A-Z' you want to start");
                word = char.ToUpper(Console.ReadKey().KeyChar );
                foreach (string city in City)
                {
                    if (city[0] == word)
                    {
                        Console.WriteLine();
                        Console.WriteLine(city);
                    }
                }

            }
            if (type == 2)
            {
                Console.WriteLine("Enter a character 'A-Z' you want to end");
                word = char.ToUpper(Console.ReadKey().KeyChar);
                foreach (string city in City)
                {
                    if (char.ToUpper (city[city.Length -1]) == word)
                    {
                        Console.WriteLine();
                        Console.WriteLine(city);
                    }
                }

            }
            else if (type!=1 && type!=2)
            { Console.WriteLine("There is something wrong!"); }
            goto a;
        }
    }
}
