using System;
using System.IO; 
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using Newtonsoft.Json.Serialization;  
using System.Text.Json;
using System.Text.Json.Serialization; 

namespace Code
{
    public class Commands
    {
        //public string commands = "commands(c), look(l), move (m), talk to NPC (talk), inventory(i), take item(take), drop item(d), save(s), quit(q)";
        public string Commandos; 

        public Commands()
        {
            Commandos = "look(l), move (m), talk to NPC (talk), attack(a), inventory(i), take item(take), drop item(d), save(s), quit(q)"; 
        }

        public void showCommands()
        {
            Commands commands = new Commands(); 
            Console.WriteLine(commands.Commandos); 
        }

        public void useCommands(List<Item> items, List<NPC> npcs, List<Area> areas, List<Item> npcItems, PlayerCharacter character, Area actualArea, Commands commands)
        {
            commands.showCommands(); 

            Console.WriteLine("What would you like to do?"); 

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                /*case "c":
                case "commands":  
                showCommands(commands); 
                break; */

                case "l": 
                case "look": 
                Console.WriteLine(actualArea.Description);
                List<Item> areaItems = actualArea.Items;
                int numberOfItems = areaItems.Count; 

                Console.WriteLine("You see: "); 

                if (numberOfItems == 0)
                {
                    Console.WriteLine("No Items."); 
                }

                if (numberOfItems == 1)
                { 
                    Console.WriteLine(areaItems[0].Description); 
                }

                else 
                {
                    foreach (Item aItem in areaItems)
                    { 
                        Console.WriteLine(aItem.Name); 
                        Console.WriteLine(aItem.Description); 
                    } 
                }
                break; 

                case "talk": 
                case "talk to": 
                case "talk to NPC": 
                actualArea.NPC.talk(actualArea.NPC); 
                break; 

                case "a": 
                case "attack": 
                character.fight(character, actualArea); 
                break; 

                case "m":
                case "move": 
                character.move(areas); 
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
                saveGame(items, npcs, areas, npcItems, character);  
                break; 

                case "q":
                case "quit":  
                quitGame();
                break; 

                default: 
                Console.WriteLine("I don't understand this. Please use one of the following commands:");
                //showCommands(commands); 
                break; 
            } 
        }
        public static void saveGame(List<Item> items, List<NPC> npcs, List<Area> areas, List<Item> npcItems, PlayerCharacter player)
        {

            writeJSON.saveData(items, "gameData/savedItems.json");

    
            writeJSON.saveData(npcItems, "gameData/savedNPCItems.json");
        

            List<String[]> npcMock = new List<String[]>();
            for (int i = 0; i < npcs.Count; i++)
            {
                String item = null;
                if (npcs[i].Inventory != null)
                {
                    item = "npcItem" + i.ToString();
                } 

                String[] temp = {npcs[i].Name, npcs[i].HP.ToString(), npcs[i].Damage.ToString(), npcs[i].IsDead.ToString(), npcs[i].IsPlayerCharacter.ToString(), item, npcs[i].Dialogue, npcs[i].IfAttacked};
                npcMock.Add(temp);
            }
            writeJSON.saveData(npcMock, "gameData/savedNPCs.json");

            
            List<String[]> areaMock = new List<String[]>();
            for (int i = 0; i < areas.Count; i++)
            {
                String item = null;
                String npc = null;

                if (areas[i].Items != null)
                {
                    item = "item" + i.ToString();
                } 
                
                if (areas[i].NPC.IsDead != true) 
                {
                    npc = "npc" + i.ToString();
                }

                String[] temp = {areas[i].Description, item, npc, areas[i].Type, areas[i].Position, areas[i].IsActualArea.ToString()};
                areaMock.Add(temp);
            }
            writeJSON.saveData(areaMock, "gameData/savedAreas.json");

        
            List<String[]> playerMock = new List<string[]>();
            String inventory = "empty";

            if (player.Inventory.Count != 0)
            {
                for (int i = 0; i < player.Inventory.Count; i++)
                {
                    inventory = "inventory" + player.Inventory[i].ToString(); 
                }
            }
            String[] temp2 = {player.Name, player.HP.ToString(), player.Damage.ToString(), player.IsDead.ToString(), player.IsPlayerCharacter.ToString(), inventory};
            playerMock.Add(temp2);
            writeJSON.saveData(playerMock, "gameData/savedPlayer.json");
        }

        public static void quitGame()
        {
            Environment.Exit(0); 
        }
    }
}
