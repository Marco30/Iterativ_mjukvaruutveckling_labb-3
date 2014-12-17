using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3
{
    class login
    {
        
        public login()
        {

            Console.WriteLine("\nSign In\n-----------------------");

            Console.WriteLine("\nAnvändarnamn :");
            string name = Console.ReadLine();

            Console.WriteLine("\nPassword");
            string password = Console.ReadLine();

            control B1 = new control(name, password);

            B1.logincontrol();

        }

       
    }
}
