using System;

namespace exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail1 = "ich@provider.com"; //true
            string mail2 = "@wus.com"; //false
            string mail3 = "m@."; //true 
            string mail4 ="7@gmail.com"; //true

            Console.WriteLine(mail.IsEmailAddress(mail1)); 
            if (mail.IsEmailAddress(mail1))
                Console.WriteLine("TEST PASSED: " + mail1 + " korrekt als Email-Adresse erkannt");
            else
                Console.WriteLine("TEST FAILED: " + mail1 + " nicht als Email-Adresse erkannt, obwohl korrekt.");


            Console.WriteLine(mail.IsEmailAddress(mail2)); 
            if (mail.IsEmailAddress(mail2))
                Console.WriteLine("TEST PASSED: " + mail2 + " korrekt als Email-Adresse erkannt");
            else
                Console.WriteLine("TEST FAILED: " + mail2 + " nicht als Email-Adresse erkannt, obwohl korrekt.");


            Console.WriteLine(mail.IsEmailAddress(mail3)); 
            if (mail.IsEmailAddress(mail3))
                Console.WriteLine("TEST PASSED: " + mail3 + " korrekt als Email-Adresse erkannt");
            else
                Console.WriteLine("TEST FAILED: " + mail3 + " nicht als Email-Adresse erkannt, obwohl korrekt.");



            Console.WriteLine(mail.IsEmailAddress(mail4)); 
            if (mail.IsEmailAddress(mail4))
                Console.WriteLine("TEST PASSED: " + mail4 + " korrekt als Email-Adresse erkannt");
            else
                Console.WriteLine("TEST FAILED: " + mail4 + " nicht als Email-Adresse erkannt, obwohl korrekt.");
        }
    }


    class mail
    {
        public static bool IsEmailAddress(string emailAddress)
            {
                int iAt = emailAddress.IndexOf('@');
                int iDot = emailAddress.LastIndexOf('.');
                return (iAt > 0 && iDot > iAt);
            }
    }
}
