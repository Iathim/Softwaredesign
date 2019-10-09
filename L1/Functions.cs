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
            string[] textArray = text.Split(" ");
            string[] reversedArray = new string[textArray.Length];

            for (int i = 0; i < textArray.Length; i++) 
            {
                reversedArray[i] = (textArray[i]);
                Array.Reverse(reversedArray); 
            }
            string reversedString = string.Join(" ", reversedArray);
            
            return reversedString;
            }


       public static string reverseSentence (string text)
       {

           return text; 
       }
    }
}
