using System;
using System.IO; 

namespace _Quiz_new_
{
    class MainQuiz
    {
        public static int score; 
        public static int questionAnswered; 

        //public static List<QuizElement> questions = new List<QuizElement>(); 
        public static void Main(string[] args)
        {
            //QuizElementText text1 = new QuizElementText[_question = ""]; 
            //erstellen von Quizelementen in Funktion auslagern 
             StreamReader file = new StreamReader(@"Quizelements.json");
            
            
            
            
            string userInput = Menue.displayMenue(); 

            if (userInput == null)
            {
                userInput = Menue.displayMenue(); 
            }

            else //Swich case mit userInput? 
            {
                if (userInput == "1")
                {
                    //Play Quiz 
                }

                if (userInput == "2")
                {
                    //Create new Quizelement 
                    //Returns Quizelement which has to be saved to the QuizelementList/Question
                }

                if (userInput == "3")
                {
                    //exit game 
                }
            }
        }
    }
}
