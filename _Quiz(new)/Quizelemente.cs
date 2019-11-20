using System;

namespace _Quiz_new_
{
    class QuizElement
    {
        public string question; 


        public void display()
        {

        }


        public Boolean checkAnswers(string answers)
        {


            return false; 
        }


        public QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }

    }


    class Answer
    {
        string text; 
        Boolean isTrue; 
    }



    class QuizElementTrueFalse : QuizElement
    {
        Boolean trueFalse; 

        public new void display()
        {
            Console.WriteLine(question);

            Console.WriteLine("Answer 'Y' for yes/true or 'N' for no/false."); 
        }


        public new Boolean checkAnswers(string answers)
        {


            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }


    class QuizElementText : QuizElement
    {
        Answer answer = new Answer(); 

        public new void display()
        {
            Console.WriteLine(question); 
            
            Console.WriteLine("Please write the correct answer by using your keyboard."); 
        }


        public new Boolean checkAnswers(string answers)
        {


            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }


    class QuizElementGuess : QuizElement
    {
        float tolerance; 

        float correctAnswer;  

        public new void display()
        {
            Console.WriteLine(question); 

            Console.WriteLine("Please write your guess. Use '.' if you want to write a decimal number."); 
        }


        public new Boolean checkAnswers(string answers)
        {


            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }



    class QuizElementMultiAnswer : QuizElement
    {
        Answer[] answers = new Answer[6];   

        public new void display()
        {
            Console.WriteLine(question); 

            Console.WriteLine("There is more than one answer correct. Please type the number(s) of the answer(s) you think is correct one after another."); 
            Console.WriteLine("Please don't write the same number twice."); 
            Console.WriteLine("Press Enter if your finished answering the questions."); 
        }


        public new Boolean checkAnswers(string answers)
        {


            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }


    class QuizElementSingleAnswer : QuizElement
    {
        Answer[] answers = new Answer[6];  

        public new void display()
        {
            Console.WriteLine(question);

            Console.WriteLine("Only one answer is correct. Please enter the number of the answer you think is correct."); 
        }


        public new Boolean checkAnswers(string answers)
        {


            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }
}
