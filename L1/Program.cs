using System;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Bitte einen kleinen Satz eingeben");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = Functions.reverseLetters(text); 
            string words = Functions.reverseWords(text);
            string sentence = Functions.reverseSentence(text);
            Console.WriteLine(sentence + "\n" + words + "\n" + letters);*/ 

            string word = "Satz zum Testen"; 

            //word = Functions.reverseLetters(word);
            
            word = Functions.reverseWords(word); 

            Console.WriteLine(word); 


        }
    }
}
