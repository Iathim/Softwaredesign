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

        public void useCommands(PlayerCharacter character, Area actualArea, List<Area> areas, Commands commands)
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
                saveGame(character, areas);  
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
        public static void saveGame(PlayerCharacter player, List<Area> areas)
        {
            JObject playerCharacter = new JObject(
            new JProperty("Name", player.Name),
            new JProperty("HP", player.HP),
            new JProperty("Damage", player.Damage),
            new JProperty("IsDead", player.IsDead),
            new JProperty("IsPlayerCharacter", player.IsPlayerCharacter), 
            new JProperty("Inventory", player.Inventory)); 

            File.WriteAllText(@"c:\PlayerCharacter.json", playerCharacter.ToString());

            
            using (StreamWriter playerFile = File.CreateText(@"c:\PlayerCharacter.json"))
            using (JsonTextWriter writer = new JsonTextWriter(playerFile))
            {
                playerCharacter.WriteTo(writer);
            }

            JObject area = new JObject(
            new JProperty("Description", areas[0].Description),
            new JProperty("Items", "items1"),
            new JProperty("NPC", "npc1"),
            new JProperty("Type", areas[0].Type),
            new JProperty("Position", areas[0].Position), 
            new JProperty("IsActualArea", areas[0].IsActualArea)); 

            JObject area2 = new JObject(
            new JProperty("Description", areas[1].Description),
            new JProperty("Items", "items2"),
            new JProperty("NPC", "npc2"),
            new JProperty("Type", areas[1].Type),
            new JProperty("Position", areas[1].Position), 
            new JProperty("IsActualArea", areas[1].IsActualArea));

            JObject area3 = new JObject(
            new JProperty("Description", areas[2].Description),
            new JProperty("Items", "items3"),
            new JProperty("NPC", "npc3"),
            new JProperty("Type", areas[2].Type),
            new JProperty("Position", areas[2].Position), 
            new JProperty("IsActualArea", areas[2].IsActualArea)); 

            JObject area4 = new JObject(
            new JProperty("Description", areas[3].Description),
            new JProperty("Items", "items4"),
            new JProperty("NPC", "npc4"),
            new JProperty("Type", areas[3].Type),
            new JProperty("Position", areas[3].Position), 
            new JProperty("IsActualArea", areas[3].IsActualArea)); 

            JObject area5 = new JObject(
            new JProperty("Description", areas[4].Description),
            new JProperty("Items", "items5"),
            new JProperty("NPC", "npc5"),
            new JProperty("Type", areas[4].Type),
            new JProperty("Position", areas[4].Position), 
            new JProperty("IsActualArea", areas[4].IsActualArea)); 

            area.Add(area2); 
            area.Add(area3); 
            area.Add(area4); 
            area.Add(area5); 


            File.WriteAllText(@"c:\PlayerCharacter.json", area.ToString());

            
            using (StreamWriter file = File.CreateText(@"c:\area.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                area.WriteTo(writer);
            }

            /*JObject item1 = new JObject(
            new JProperty("Name", areas[0].Items),
            new JProperty("Description", player.Inventory)); 

            File.WriteAllText(@"c:\PlayerCharacter.json", playerCharacter.ToString());

            
            using (StreamWriter playerFile = File.CreateText(@"c:\PlayerCharacter.json"))
            using (JsonTextWriter writer = new JsonTextWriter(playerFile))
            {
                playerCharacter.WriteTo(writer);
            }*/
        }

        public static void quitGame()
        {
            Environment.Exit(0); 
        }
    }
}
