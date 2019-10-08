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
    }
}
