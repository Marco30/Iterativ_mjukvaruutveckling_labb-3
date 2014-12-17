using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb3
{
    class control
    {
         //använder understräck i dem två variablerna här under för att visa att de är privat
        private string _name;
        private string _password;

        private List<string> namen = new List<string>();

        private List<string> password = new List<string>();

        public control()// konstruktor som används till att initialiserar _mane och _password
        {
            
        }
        public control(string nam, string psw)// konstruktor som används till att initialiserar _mane och _password
        {
            GetName = nam;
            GetPassword = psw;

        }

        public string GetName // ger oss till gång till den privata variablerna _name genom get os set
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string GetPassword// ger oss till gång till den privata variablerna _password genom get os set
        {
            get
            {
                return _password; 
            }
            set
            {
               
                _password = value;
            }
        }

        public int logincontrol()
        {

            Load();

            int hitat = 0;

            for (int i = 0; i < namen.Count; i++) 
            {
                if(GetName == namen[i] && GetPassword == password[i])
                {
                    Console.WriteLine("\nDu är inloggad\n");
                    hitat++;
                    break;
                }
                
            }

            if(hitat == 0)
            {
                Console.WriteLine("\nDu fins inte i systemet, kontrollera att inloggnings namn och pwassword är rätt\n");
            }

              return hitat;

        }

        public void Load() // Läser dat från text fil
        {

            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == "[Namn]")
                    {

                        while ((line = reader.ReadLine()) != null)
                        {



                            if (line == "[Password]")
                            {

                                while ((line = reader.ReadLine()) != null)
                                {
                                    password.Add(line);
                                }
                                break;
                            }
                            namen.Add(line);

                        }

                    }


                }
            }

            Console.WriteLine("\nMedlemsregiste\n---------------------");
            Console.WriteLine("\nNamn\n---------------------");
            foreach (string s in namen)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nPassword\n---------------------");
            foreach (string a in password)
            {
                Console.WriteLine(a);
            }


        }

        public void add(string n, string p)// Läger till ny användare i medlemsregistret
        {
            namen.Add(n);
            password.Add(p);
            Load();
            Save();
            
        }


        public void Save()// Sparar data till text fil
        {


            int m = 0;

            using (StreamWriter writer = new StreamWriter("TextFile1.txt"))
            {


                if (m == 0)
                {
                    writer.WriteLine("[Namn]");
                    m++;
                }

                for (int i = 0; i < namen.Count; i++) // Loopar igenom lista
                {

                    writer.WriteLine(namen[i]);
                }

                if (m == 1)
                {
                    writer.WriteLine("[Password]");
                    m++;
                }

                for (int i = 0; i < password.Count; i++) /// Loopar igenom lista
                {

                    writer.WriteLine(password[i]);
                }

            }

        }
        
    }
}
