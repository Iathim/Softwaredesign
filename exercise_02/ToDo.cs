using System;

namespace exercise_02
{
    class ToDo
    {
        public static void firstDo()
        { 
            /*int i = 42;
            double pi = 3.1415;
            string salute = "Hello, World";*/

            var i = 42; 
            var pi = 3.1415; 
            var salute = "Hello, World"; 

            var variableInt = 0; 
            var variableDouble = 0D; 
            var variableFloat = 0F; 
            var variableShort = (short)0; 

            Console.WriteLine(i); 
            Console.WriteLine(pi); 
            Console.WriteLine(salute); 

            Console.WriteLine(variableInt); 
            Console.WriteLine(variableDouble); 
            Console.WriteLine(variableFloat); 
            Console.WriteLine(variableShort); 
        }


        public static void secondDo()
        {
            /*int[] ia = new int[10];
            char[] ca = new char[30];
            double[] da = new double[12];*/

            int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6, 7};

            int ergebnis = ia[2] * ia[8] + ia[4]; //2 * 5 + 3 

            Console.WriteLine(ergebnis); //13 

            double[] numbers = {3.1415, 2.7183, Math.Round(2.79 * Math.Pow(10, -19))}; 

            Console.WriteLine(ia.Length); 
        }

        public static void thirdDo()
        {
            string meinString = "Dies ist ein String";
            char zeichen = meinString[5];

            string a = "eins";
            string b = "zwei";
            string c = "eins";

            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);

            Console.WriteLine(meinString); 

            Console.WriteLine(c); 

            Console.WriteLine(a_eq_b); 
            Console.WriteLine(a_eq_c); 

            Console.WriteLine(zeichen); 
        }


         public class Person
        {
            public string Name;
            public int Personalnummer;  
        }

        public static void forthDo()
        { 
            /*Person jemand = new Person();
            jemand.Name = "Horst";
            jemand.Personalnummer = 42;*/ 

            Person jemand = new Person {Name="Horst", Personalnummer=42};
        }


        public static void fithDo()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            /*if (a > b)
            {
                Console.WriteLine("a ist größer als b"); 
            }

            else 
            {
                Console.WriteLine("b ist grö0er als a"); 
            }*/ 

            if (a > 3 && b == 6)
            {
                Console.WriteLine("Du hast gewonnen! :)"); 
            }

            else 
            { 
                Console.WriteLine("Du hast verloren :("); 
            }
        }

        public static void sixthDo()
        {
            /*int i = int.Parse(Console.ReadLine());
            switch (i)
            {
            case 1:
                Console.WriteLine("Du hast EINS eingegeben");
                break;
            case 2:
                Console.WriteLine("ZWEI war Deine Wahl");
                break;
            case 3:
                Console.WriteLine("Du tipptest eine DREI");
                break;
            case 4: 
                Console.WriteLine("Sauron schenkte genauso viele Ringe den Zwerge, wie du soeben eingetippt hast: SIEBEN!"); 
                break; 
            default:
                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                break;
            }*/

            string i = Console.ReadLine(); 

            /*switch (i)
            {
            case "Eins":
                Console.WriteLine("Du hast EINS eingegeben");
                break;
            case "Zwei":
                Console.WriteLine("ZWEI war Deine Wahl");
                break;
            case "Drei":
                Console.WriteLine("Du tipptest eine DREI");
                break;
            case "Sieben": 
                Console.WriteLine("Sauron schenkte genauso viele Ringe den Zwerge, wie du soeben eingetippt hast: SIEBEN!"); 
                break; 
            default:
                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                break;
            }*/ 

            if (i == "Eins")
            {
                Console.WriteLine("Du hast EINS eingegeben");
            }

            if (i == "Zwei")
            {
                Console.WriteLine("ZWEI war Deine Wahl");
            }

            if (i == "Drei")
            {
                Console.WriteLine("Du tipptest eine DREI");
            }

            if (i == "Sieben")
            {
                Console.WriteLine("Sauron schenkte genauso viele Ringe den Zwerge, wie du soeben eingetippt hast: SIEBEN!"); 
            }

            else 
            {
                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
            }
        }

        public static void seventhDo()
        {
            int [] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int i = 0; 
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]); 
                i++; 
            }
        }

        public static void eightDo() 
        {
            int i = 0; 
            string[] someStrings = 
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };
            
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(someStrings[i]);
            }*/ 

            /*while (i < someStrings.Length)
            {
                Console.WriteLine(someStrings[i]);
                i++; 
            }*/

             
            /*do
            {
                Console.WriteLine(someStrings[i]);
                i++;
            }
            while (i < someStrings.Length);*()


            /*while (true)
            {
                Console.WriteLine(someStrings[i]);
                if (i >= someStrings.Length)
                break;
                i++;
            }*/


           foreach (string s in someStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
