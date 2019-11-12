using System;

namespace Quiz
{
    class programm
    {
        public static void Main(string[] args)
        {
            int score = 0; 

            //int questionsAnswered = 0; 

            /*Quizelement.Quizelemente question1 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question2 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question3 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question4 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question5 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question6 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question7 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; 
            Quizelement.Quizelemente question8 = new Quizelement.Quizelemente{question = "", rightAnswer = "", wrongAnswers = {} }; */

            //menue.showMenue(score); 

            //Menue 

            Console.WriteLine("Sie befinden sich im Menü."); 

            Console.WriteLine("Ihr aktueller Punktestand ist " + score); 

            Console.WriteLine("Geben Sie 1 ein, um das Quiz zu starten."); 

            Console.WriteLine("Geben Sie 2 ein, um ein neues Quizelement zu erstellen."); 

            Console.WriteLine("Geben Sie 3 ein, um das Programm zu beenden"); 

            string inputUser = Console.ReadLine(); 

            if (inputUser == "1")
            {
                //Quiz gets started 
                GamePlay.Game.answerQuestions(); 
            }

            if (inputUser == "2")
            {
                //new Quizelement will be created by the user 

            }

            if (inputUser == "3")
            { 
                //Programm will be exited 

            }

            else 
            { 
                Console.WriteLine("Bitte geben Sie ein gültiges Zeichen ein: 1, 2 oder 3."); 
            }
            
        }
    }


    /*class menue
    {
        public static void showMenue(int score)
        {
            Console.WriteLine("Sie befinden sich im Menü."); 

            Console.WriteLine("Ihr aktueller Punktestand ist " + score); 

            Console.WriteLine("Geben Sie 1 ein, um das Quiz zu starten."); 

            Console.WriteLine("Geben Sie 2 ein, um ein neues Quizelement zu erstellen."); 

            Console.WriteLine("Geben Sie 3 ein, um das Programm zu beenden"); 

            string inputUser = Console.ReadLine(); 

            if (inputUser == "1")
            {
                //Quiz gets started 

            }

            if (inputUser == "2")
            {
                //new Quizelement will be created by the user 

            }

            if (inputUser == "3")
            { 
                //Programm will be exited 

            }

            else 
            { 
                Console.WriteLine("Bitte geben Sie ein gültiges Zeichen ein: 1, 2 oder 3."); 
            }
        }

    }*/
}
