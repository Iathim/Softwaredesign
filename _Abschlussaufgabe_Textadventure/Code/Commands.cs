using System;

namespace Code
{
    public class Commands
    {
        //public string commands = "commands(c), look(l), inventory(i), take item(t), drop item(d), save (s), quit(q)";
        public string commands;  

        public static void showCommands(Commands commands)
        {
            Console.WriteLine(commands.commands); 
        }

        public void useCommands(PlayerCharacter character, Area area, Commands commands)
        {
            showCommands(commands); 

            string userInput = Console.ReadLine(); 

            if (userInput == "c" || userInput == "commands")
            {
                showCommands(commands); 
            }

            if (userInput == "l" || userInput == "look")
            {
                Console.WriteLine(area.destription); 
            }

            if (userInput == "i" || userInput == "inventory")
            {
                Console.WriteLine(character.inventory); 
            }

            if (userInput == "t" || userInput == "take" || userInput == "take item" || userInput == "take Item")
            {
                character.takeItem(area, character); 
            }

            if (userInput == "d" || userInput == "drop" || userInput == "drop item" || userInput == "drop Item")
            {
                character.dropItem(character, area); 
            }

            if (userInput == "s" || userInput == "save")
            {
                saveGame(); 
            }

            if (userInput == "q" || userInput == "quit")
            {
                Console.WriteLine("Are you sure you want to quit the game?"); 
                Console.WriteLine("Type 'q' again to confirm."); 
                
                string userAcknowlegdment = Console.ReadLine(); 

                if (userAcknowlegdment != "q")
                {
                    showCommands(commands); 
                }
                
                else
                {
                    quitGame();
                }
            }

            else 
            {
                Console.WriteLine("I don't understand this. Please use one of the following commands");
                showCommands(commands);  
            }
        }

        public void saveGame()
        {

        }

        public static void quitGame()
        {

        }
    }
}
