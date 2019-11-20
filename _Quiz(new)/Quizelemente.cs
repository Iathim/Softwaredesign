using System;

namespace _Quiz_new_
{
    class QuizElement
    {
        public string _question; 


        public void display()
        {
            Console.WriteLine(_question); 
        }


        public Boolean checkAnswers(string userAnswer)
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
        public string _text; 
        public Boolean _isTrue; 
    }



    class QuizElementTrueFalse : QuizElement
    {
        Boolean isTrue; 

        public new void display()
        {
            Console.WriteLine(_question);

            Console.WriteLine("Answer 'Y' for yes/true or 'N' for no/false."); 
        }


        public new Boolean checkAnswers(string userAnswer)
        {
            Boolean answerValue = false; 

            if (userAnswer != "Y" || userAnswer != "N" || userAnswer != "y" || userAnswer != "n")
            {
                Console.WriteLine("Please give a valid input: 'Y' for yes/true or 'N' for no/false."); 

                userAnswer = Console.ReadLine(); 

                checkAnswers(userAnswer); 
            }

            else 
            {
                if (userAnswer == "Y" || userAnswer == "y")
                {
                    answerValue = true; 
                }

                else 
                {
                    answerValue = false; 
                }
            }


            if (answerValue == isTrue)
            {
                return true; 
            }

            else
            {
                return false; 
            }
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
            Console.WriteLine(_question); 
            
            Console.WriteLine("Please write the correct answer by using your keyboard."); 
        }


        public new Boolean checkAnswers(string userAnswer)
        {
            if (userAnswer == answer._text)
            {
                return true; 
            }

            else
            {
                return false; 
            }
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
            Console.WriteLine(_question); 

            Console.WriteLine("Please write your guess. Use '.' if you want to write a decimal number."); 
        }


        public new Boolean checkAnswers(string userAnswer)
        {
            //Invalid input = ',' and letters -> error in userAnswerNumber 
            
            /*string invalidInput = ","; 

            Boolean invalidInputFound = userAnswer.Contains(invalidInput); 

            if (invalidInputFound == true)
            {
                Console.WriteLine("Please user '.' to describe a decimal number."); 

                userAnswer = Console.ReadLine(); 

                checkAnswers(userAnswer); 
            }*/


            

            float toleranceMin = correctAnswer - tolerance; 

            float toleranceMax = correctAnswer + tolerance; 

            float userAnswerNumber = float.Parse(userAnswer); //excaption: userAnswer has ',', letters oder more than one '.' in it 

            if (userAnswerNumber <= toleranceMax && userAnswerNumber >= toleranceMin)
            {
                return true; 
            }

            else
            {
                return false; 
            } 
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
            Console.WriteLine(_question); 

            Console.WriteLine("There is more than one answer correct. Please type the number(s) of the answer(s) you think is correct one after another."); 
            Console.WriteLine("Please refrain from writing the same number twice."); 
            Console.WriteLine("Press Enter if your finished answering the questions."); 
        }


        public new Boolean checkAnswers(string userAnswer)
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
            Console.WriteLine(_question);

            Console.WriteLine("Only one answer is correct. Please enter the number of the answer you think is correct."); 
        }


        public new Boolean checkAnswers(string userAnswer)
        {


            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }
}
