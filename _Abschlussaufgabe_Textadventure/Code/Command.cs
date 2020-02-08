using System;
using System.Collections.Generic;

namespace Code
{
    public class Commands
    {
        //public string commands = "commands(c), look(l), move (m), talk to NPC (talk), inventory(i), take item(take), drop item(d), save(s), quit(q)";
        public string commands;  

        public static void showCommands(Commands commands)
        {
            Console.WriteLine(commands.commands); 
        }

        public static void useCommands(PlayerCharacter character, Area actualArea, Area[] areas, Commands commands)
        {
            showCommands(commands); 

            Console.WriteLine("What would you like to do?"); 

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "c":
                case "commands":  
                showCommands(commands); 
                break;  

                case "l": 
                case "look": 
                Console.WriteLine(actualArea.destription); 
                break; 

                case "talk": 
                case "talk to": 
                case "talk to NPC": 
                actualArea.NPC.talk(actualArea.NPC); 
                break; 

                case "m":
                case "move": 
                character.move(actualArea, areas); 
                break; 

                case "take": 
                case "take item": 
                case "take Item": 
                character.takeItem(actualArea, character); 
                break; 

                case "i": 
                case "inventory":
                character.showInventory(character); 
                break; 

                case "d":
                case "drop item": 
                case "drop Item": 
                character.dropItem(character, actualArea);  
                break; 

                case "s":
                case "save": 
                saveGame();  
                break; 

                case "q":
                case "quit":  
                quitGame();
                break; 

                default: 
                Console.WriteLine("I don't understand this. Please use one of the following commands");
                showCommands(commands); 
                break; 
            } 
        }

        public static void saveGame()
        {

        }

        public static void quitGame()
        {
            Environment.Exit(0); 
        }
    }
}
