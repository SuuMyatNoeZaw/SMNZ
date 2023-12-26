using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_SMN
{
    internal class Program
    {
       
       void Group(List<string> gp)
        {
            for(int i = 0; i < gp.Count; i++)
            {
                for (int j = i + 1; j < gp.Count; j++)
                {
                    Console.WriteLine(gp[i] + " Vs " + gp[j]);
                }
            }
        }
      
       

         static void Main(string[] args)
        {

            int first, second, third, fourth, fifth;
            List<string> Cname = new List<string>();
            Cname.Add("Myanmar");       
            Cname.Add("Laos");
            Cname.Add("Vietnum");
            Cname.Add("Singapore");
            Cname.Add("Malaysia");
            Cname.Add("Thailand");
            Cname.Add("Indonesia");
            Cname.Add("Canbodia");
            Cname.Add("Philippines");
            Cname.Add("Brunei Darussalam");


            List<string> groupA = new List<string>();
            List<string> groupB = new List<string>();
            Console.WriteLine("Please Enter a number from 0 to 9 and Noticed Don't type a number twice!");
            Console.WriteLine("First");
            first = int.Parse (Console.ReadLine());
            Console.WriteLine("Second--->");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine("Third--->");
            third = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth--->");
            fourth = int.Parse(Console.ReadLine());
            Console.WriteLine("Fifth--->");
            fifth = int.Parse(Console.ReadLine());
            
            if ((first >= 0 && first <= 9) && (second >= 0 && second <= 9) && (third >= 0 && third <= 9) && (fourth >= 0 && fourth <= 9) && (fifth >= 0 && fifth <= 9))
            {
                if (first >= 0 && first <= 9)
                {

                    groupA.Add(Cname[first]);
                    
                }

                if ((second >= 0 && second <= 9) &&( second != first))
                {

                    groupA.Add(Cname[second]);
                    
                }

                if (third >= 0 && third <= 9 && third != first && third != second)
                {

                    groupA.Add(Cname[third]);
                   
                }

                if (fourth >= 0 && fourth <= 9 && fourth != first && fourth != second && fourth != third)
                {

                    groupA.Add(Cname[fourth]);
                    
                }

                if (fifth >= 0 && fifth <= 9 && fifth != first && fifth != second && fifth != third && fifth != fourth)
                {

                    groupA.Add(Cname[fifth]);
                    Console.WriteLine();
                    Console.WriteLine("GroupA Country List");
                    foreach (string A in groupA)
                    {
                        Console.WriteLine(A);
                    }
                    if (groupA.Count == 5)
                    { for (int i = 0; i < groupA.Count; i++)
                        {
                            Cname.Remove(groupA[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("GroupB Country List");
                        foreach (string C in Cname)
                        {
                            Console.WriteLine(C);
                        }
                        
                        if (Cname.Count == 5)
                        {
                            for (int i = 0; i < Cname.Count; i++)
                            {
                                groupB.Add(Cname[i]);

                            }
                        }
                        Console.WriteLine();
                    }

                }
               
               
               
            }
            else { Console.WriteLine("There is something wrong!"); }

           

            

            Program p = new Program();
            Console.WriteLine("For Group(A)");
            p.Group(groupA);
            Console.WriteLine();
            Console.WriteLine("For Group(B)");
            p.Group(groupB);

        }
    }
}
