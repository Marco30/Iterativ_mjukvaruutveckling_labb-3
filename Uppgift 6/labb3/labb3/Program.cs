using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3
{
    class Program
    {
        static void Main(string[] args)// visar meny 
        {

            int val = 0;
            Boolean M = false;

            while (true)
            {

                Console.WriteLine("\nMeny\n-----------------------");
                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Register new user");
                Console.WriteLine("3. Exit");
                Console.WriteLine("-----------------------");

                

                try
                {
                     val = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valet fins inte i menyn");
                    M = true;
                }

                if (M == false)
                {

                    if (val == 1)
                    {
                        login B1 = new login();
                    }

                    else if (val == 2)
                    {
                        regist B2 = new regist();
                        B2.newuser();
                    }
                    else if (val == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valet fins inte i menyn");
                    }
                }

                M = false;
            }


        }
    }
}
