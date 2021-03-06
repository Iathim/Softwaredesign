﻿using System;

namespace emailChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail1 = "ich@provider.com"; //true
            string mail2 = "@wus.com"; //false
            string mail3 = "m@."; //true 
            string mail4 ="7@gmail.com"; //true

            mail.Test(mail1); 
            mail.Test(mail2); 
            mail.Test(mail3); 
            mail.Test(mail4); 
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


        public static void Test (string email)
        {
            if (mail.IsEmailAddress(email))
                Console.WriteLine("TEST PASSED: " + email + " korrekt als Email-Adresse erkannt");
            else
                Console.WriteLine("TEST FAILED: " + email + " nicht als Email-Adresse erkannt.");
        }
    }
}
