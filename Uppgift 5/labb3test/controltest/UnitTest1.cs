using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using labb3test;

namespace controltest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        public void TestMethod1()
        {
            //Här testar jag logincontrol() i klasen control, funktionen kommer i systemet att jämföra inmatade användarnamn och lösenord med registrerade användare. 
            // om man finns med i registret så ska funktionen meddela att man är in loggade eller om man inte finns med i systemet så ska det meddelas att man inte finns i systemet   

            // test 1, funktion logincontrol(), scenario 1, resultat: du är inlogad

            //Följande användare finns registrerade i systemet
            //Användarnamn: Marco
            //Lösenord: 123


            string name = "Marco";

            string password = "123";

            control b1 = new control(name, password);

            b1.logincontrol();


        }

        [TestMethod]
        public void TestMethod2()
        {
            //Här testar jag logincontrol() i klasen control, funktionen kommer i systemet att jämföra inmatade användarnamn och lösenord med registrerade användare. 
            //Om man finns med i registret så ska funktionen meddela att man är in loggade eller om man inte finns med i systemet så ska det meddelas att man inte finns i systemet 

            // test 2, funktion logincontrol(), alternativ scenario 1, resultat: inte inlogad

            //Följande användare finns inte registrerade i systemet
            //Användarnamn: Zom
            //Lösenord: 133

            string name = "Zom";

            string password = "133";

            control b1 = new control(name, password);

            b1.logincontrol();


        }

        [TestMethod]
        public void TestMethod3()
        {
            //Här testar jag add() i klasen control, funktionen kommer i systemet att lägga till nya användare i medlemsregister. 

            // test 3, funktion add(), scenario 1, resultat: den nya användaren finns i medlemsregister

            //Följande användare finns inte registrerade i systemet, men kommer läggas till efter testet körts 
            //Användarnamn: Ole
            //Lösenord: 6790


            string name = "Ole";

            string password = "6790";

            control b1 = new control();

            b1.add(name, password);


        }

        [TestMethod]
        public void TestMethod4()
        {
            //Här testar jag Load() i klassen control, funktionen kommer i systemet att läsa in medlemsregister från fil. den här funktionen används i systemet när man ska loggin, lägger till ny användare. 

            //Test 4, funktion Load(), scenario 1, resultat: medlemsregister skrivs ut



            control b1 = new control();

            b1.Load();


        }

        [TestMethod]
        public void TestMethod5()
        {
            //Här testar jag Save() i klassen control, funktionen kommer i systemet att spara nya data på medlemsregister fil. Den här funktionen används i systemet när man ska lägga till ny användare. 

            //Följande användare finns inte registrerade i systemet, men kommer läggas till efter testet körts.

            //Användarnamn: R2D2
            //Lösenord: 1905

            //test 5, funktion Save(), scenario 1, resultat: medlemsregister skrivs ut, ny data på användare finns med. 


            string n = "R2D2";

            string p = "1905";

            control b1 = new control();

            b1.namen.Add(n);

            b1.password.Add(p);

            b1.Load();

            b1.Save();

        }

        [TestMethod]
        public void TestMethod6()
        {
            //Här testar jag namnkontrol() i klassen Regist, funktionen kommer i systemet att kontrollera om det inmatade namnet när man registrerar har mellanslag. 

            //den här funktionen används för att kontrollera att man inte har mellanslag/blanktecken i sitt användarnamn. 

            //Användarnamn: Pet er

            // test 6, funktion namnkontrol(), scenario 1, resultat: Hittar mellanslag och får tillbaks värdet: "true" 

            string name = "Pe ter";
            bool loop;

            regist b1 = new regist();

            loop = b1.namnkontrol(name);

            Assert.IsTrue(loop, "Tester misslyckades");

            Console.WriteLine(loop);
        }


        [TestMethod]
        public void TestMethod7()
        {
            //Här testar jag namnkontrol() i klassen Regist, funktionen kommer i systemet att kontrollera om det inmatade namnet när man registrerar har mellanslag. 

            //den här funktionen används för att kontrollera att man inte har mellanslag/blanktecken i sitt användarnamn. 

            //Användarnamn: Peter

            // test 7, funktion namnkontrol(), alternativ scenario 1, resultat: Hittar inte mellanslag och får tillbaks värdet: "false" 

            string name = "Peter";
            bool loop;

            regist b1 = new regist();

            loop = b1.namnkontrol(name);

            Assert.IsFalse(loop, "Tester misslyckades");

            Console.WriteLine(loop);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //Här testar jag passwordkontrol() i klassen Regist, funktionen kommer i systemet att kontrollera om det inmatade lösenordet när man registrerar har mellanslag. 

            //den här funktionen används för att kontrollera att man inte har mellanslag/blanktecken i sitt användarlösenord. 

            //Lösenord: 12 67

            // test 8, funktion passwordkontrol(), scenario 1, resultat: Hittar mellanslag och får tillbaks värdet: "true"

            string password = "12 67";
            bool loop;

            regist b1 = new regist();

            loop = b1.passwordkontrol(password);

            Console.WriteLine(loop);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //Här testar jag passwordkontrol() i klassen Regist, funktionen kommer i systemet att kontrollera om det inmatade lösenordet när man registrerar har mellanslag. 

            //den här funktionen används för att kontrollera att man inte har mellanslag/blanktecken i sitt användarlösenord. 

            //Lösenord: 1267

            // test 9, funktion passwordkontrol(), alternativ scenario 1, resultat: Hittar inte mellanslag och får tillbaks värdet: "false" 


            string password = "1267";
            bool loop;

            regist b1 = new regist();

            loop = b1.passwordkontrol(password);

            Console.WriteLine(loop);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //Här testar jag bekrefta() i klassen Regist, funktionen kommer i systemet att ge än möjlighet att avbryta registrering. 

            //den här funktionen används för att kontrollera att man vill registrera sig 

            //val: 1 = JA

            // test 10, funktion bekrefta(), scenario 1, resultat: Val 1 = JA "Du är nu registrerad"



            string n = "test";

            string p = "test";

            int val = 1;

            regist b1 = new regist();

            b1.bekrefta(n, p, val);

        }

        [TestMethod]
        public void TestMethod11()
        {
            //Här testar jag bekrefta() i klassen Regist, funktionen kommer i systemet att ge än möjlighet att avbryta registrering. 

            //den här funktionen används för att kontrollera att man vill registrera sig 

            //val: 2 = NEJ

            // test 11, funktion bekrefta(), alternativ scenario 1, resultat: Val 2 = Nej "registrering stoppad"



            string n = "test";

            string p = "test";

            int val = 2;

            regist b1 = new regist();

            b1.bekrefta(n, p, val);

        }
    }
}
