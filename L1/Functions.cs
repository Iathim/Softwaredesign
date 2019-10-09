using System;

namespace L1
{
    class Functions
    {
       public static string reverseLetters (string text)
       {
            char[] charArray = text.ToCharArray();
            string reverseText = "";

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverseText = reverseText + charArray[i];
            }

           return reverseText; 
       }


       public static string reverseWords (string text)
       {

           return text;
       }


       public static string reverseSentence (string text)
       {

           return text; 
       }
    }
}
