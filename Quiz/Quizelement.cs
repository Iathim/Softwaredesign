using System;

namespace Quizelement
{
    class Quizelemente
    {
        public string question; 

        public string rightAnswer; 

        public string[] wrongAnswers; 



        Quizelemente question1 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question2 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question3 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question4 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question5 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question6 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question7 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
        Quizelemente question8 = new Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
    }


    class newQuizelement
    {
        public static string createNewElement()
        {
            Console.WriteLine("Bitte geben Sie ihre Frage in die Console ein."); 

            string userQuestion = Console.ReadLine(); 

            Console.WriteLine("Bitte geben Sie die richtige Antwort auf Ihre Frage ein."); 

            string userRightQuestion = Console.ReadLine(); 

            Console.WriteLine("Bitte geben Sie eine falsche Antwort ein."); 

            string[] userWrongQuestion = {Console.ReadLine()}; 

            Console.WriteLine("Bitte geben Sie eine weitere falsche Antwort ein oder speichern Sie das Quizelement mit ENTER und kehren zurück zum Menü."); 

            string input = Console.ReadLine(); 

            if (input == "ENTER")
            {

            }
            else 
            {
                userWrongQuestion[1] = input; 
            }

            return ""; 
        }
    }
}
