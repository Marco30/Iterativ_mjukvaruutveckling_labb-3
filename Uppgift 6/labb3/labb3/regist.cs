using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3
{
    class regist
    {
        public regist()// här registrerar vi ny användare 
        {

        }
        public void newuser()
        {

            string nypassword = "";
            string nyname = "";
            bool loop = true;

            Console.WriteLine("\nRegister new user\n-----------------------");

            while (loop)
            {

                Console.WriteLine("\nNamn:");

                nyname = Console.ReadLine();

                loop = namnkontrol(nyname);

            }

            loop = true;

            while (loop)
            {

                Console.WriteLine("\nPassword:");

                nypassword = Console.ReadLine();

                loop = passwordkontrol(nypassword);

            }

            bekrefta(nyname, nypassword);

        }

        public void bekrefta(string nyn, string nyp)// Visar val, godkänna registrering eller inte
        {
            control M = new control();

            while (true)
            {
                Console.WriteLine("\nRegistrera användare\n-----------------------");
                Console.WriteLine("1. Ja");
                Console.WriteLine("2. Nej");
                Console.WriteLine("-----------------------");

                int val = int.Parse(Console.ReadLine());

                if (val == 1)
                {
                    Console.WriteLine("\nDu är nu registrerad\n");

                    M.add(nyn, nyp);

                    break;
                }
                else if (val == 2)
                {
                    Console.WriteLine("\nregistrering stoppad\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nValet fins inte i menyn\n");
                }

            }

        }

        public bool namnkontrol(string n)//kontrollerar mellanslag/blanktecken i användarnamn  
        {
            bool m = true;

            bool text = n.Contains(" ");

            if (n == null || n.Length == 0)
            {
                Console.WriteLine("\nskriv in ett namn\n");
            }
            else if (text == true)
            {
                Console.WriteLine("\nDu får inte ha mellanslag i namnet\n");
            }
            else
            {

                m = false;

            }

            return m;
        }

        public bool passwordkontrol(string p)//kontrollerar mellanslag/blanktecken i lösenord  
        {

            bool m = true;

            bool text2 = p.Contains(" ");

            if (p == null || p.Length == 0)
            {
                Console.WriteLine("\nskriv in ett password\n");
            }
            else if (text2 == true)
            {
                Console.WriteLine("\nDu får inte ha mellanslag i ditt password\n");
            }
            else
            {
                m = false;
            }

            return m;
        }

    }
}
