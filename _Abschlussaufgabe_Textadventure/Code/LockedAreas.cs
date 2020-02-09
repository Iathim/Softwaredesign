using System;
using System.Collections.Generic; 

namespace Code
{
    public class LockedArea : Area
    {
        public bool isOpen;
        public string reasonWhyLocked;
        public string consequenzFailure;  
        public string consequenzSuccess;    
        public string riddle;
        public string riddleAnswer; 

        public LockedArea (string _description, List<Item> _items, NPC _NPC, string _type, string _position, bool _isActualArea, bool _isOpen, string _reasonWhyLocked,
         string _consequenzFailure, string _consequenzSuccess, string _riddle, string _riddleAnswer)
        : base (_description, _items, _NPC, _type, _position, _isActualArea)
        {
            this.description = _description; 
            this.items = _items; 
            this.NPC = _NPC; 
            this.type = _type;
            this.position = _position; 
            this.isActualArea = _isActualArea; 
            this.isOpen = _isOpen; 
            this.reasonWhyLocked = _reasonWhyLocked; 
            this.consequenzFailure = _consequenzFailure; 
            this.consequenzSuccess = _consequenzSuccess; 
            this.riddle = _riddle; 
            this.riddleAnswer = _riddleAnswer; 
        }


        public static void riddleSolution(LockedArea area, PlayerCharacter character)
        {
            /*Console.WriteLine("You tried to open the door but failed miserably."); 
            Console.WriteLine("Next to the door a panel started blinking after extending out of the wall."); 
            Console.WriteLine("You go closer to the panel and realise there is a riddle written.");*/ 
            Console.WriteLine(area.reasonWhyLocked); 

            Console.WriteLine(area.riddle); 
            Console.WriteLine("What is your answer to the riddle? Please type it in."); 

            string userInput = Console.ReadLine(); 


            if (userInput == area.riddleAnswer)
            {
                /*Console.WriteLine("The console started blinking before a light you didn't see when you first looked at it turned green."); 
                Console.WriteLine("It seems you managed to unlock the door. Well done!"); */

                Console.WriteLine(area.consequenzSuccess); 
                
                area.isOpen = false; 
            }

            else 
            {
                /*Console.WriteLine("You heard a screeching sound and the panel retired back into the wall."); 
                Console.WriteLine("Alarmed, you look around and see a small blaster pointing at you.");*/

                Console.WriteLine("The answer was wrong..."); 

                Random random = new Random();
                int randomNumber = random.Next(0, 100);


                if (randomNumber % 2 != 0)
                {
                    //Console.WriteLine("The gun is shooting at you and you don't duck down immediately. A shot grazes you.");

                    Console.WriteLine(area.consequenzFailure); 

                    int gunDemage = 20;  

                    character.HP = character.HP - gunDemage; 

                    if (character.HP <= 0)
                    {
                        character.dies(character); 
                    }

                    else 
                    {
                        Console.WriteLine("Wow, that hurt but you are still standing. So, that's a win?"); 
                        Console.WriteLine("Maybe you should think about the riddle again."); 
                    }
                }


                else 
                {
                    /*Console.WriteLine("The gun doesn't seem to funktion correctly because it shoots in the wrong direction."); 
                    Console.WriteLine("Well you got lucky but maybe think about the answer to the riddle more."); 
                    Console.WriteLine("You don't know if the gun fires the next time correctly");*/ 

                    Console.WriteLine("You managed to dodge. Lucky you.");
                }
            }
        }
    }
}
