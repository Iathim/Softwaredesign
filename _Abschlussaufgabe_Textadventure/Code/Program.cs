using System;
using System.IO;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        public static void start(List<Item> items, List<NPC> npcs, List<Area> areas, List<Item> npcItems, PlayerCharacter character, Commands commands)
        {

            Area actualArea = null;  
            foreach (Area aArea in areas)
                {
                    if(aArea.IsActualArea == true) 
                    {
                        actualArea = aArea;
                        Console.WriteLine(actualArea.Description); 
                    }
                }

            while(true)
            {
                actualArea = null;  
                foreach (Area aArea in areas)
                    {
                        if(aArea.IsActualArea == true) 
                        {
                            actualArea = aArea;
                            //Console.WriteLine(actualArea.description); 
                        }
                    }
                commands.useCommands(items, npcs, areas, npcItems, character, actualArea, commands);
            }
        }
        static void Main(string[] args)
        {
            String[] orignalData = 
            {
                "gameData/originalData/item.json",
                "gameData/originalData/npcItem.json",
                "gameData/originalData/npc.json",
                "gameData/originalData/area.json",
                "gameData/originalData/player.json"        
            };

            String[] savedData =
            {
                "gameData/savedItems.json",
                "gameData/savedNPCItems.json",
                "gameData/savedNPCs.json",
                "gameData/savedAreas.json",
                "gameData/savedPlayer.json"
            };


    
            List<Item> items = new List<Item>();
            List<Item> npcItems = new List<Item>();
            List<NPC> npcs = new List<NPC>();
            List<Area> areas = new List<Area>();
            PlayerCharacter player = null;

  
            List<String[]> itemsString = new List<String[]>();
            List<String[]> npcItemsString = new List<String[]>();
            List<String[]> npcsString = new List<String[]>();
            List<String[]> areasString = new List<String[]>();
            List<String[]> playerString = new List<String[]>();

            
            Console.WriteLine("Do you want to start a new game or load already saved game data?");
            Console.WriteLine("Type load if you want to load a saved game."); 
            string userInput = Console.ReadLine();  


            if(File.Exists("gameData/savedPlayer.json") && userInput == "load")
            { 
                itemsString = readJSON.LoadObjects(savedData[0]);
                npcItemsString = readJSON.LoadObjects(savedData[1]);
                npcsString = readJSON.LoadSavedObjects(savedData[2]);
                areasString = readJSON.LoadSavedObjects(savedData[3]);
                playerString = readJSON.LoadSavedObjects(savedData[4]);
                Console.WriteLine("Save Game has been loaded!");
            }

            if(!File.Exists("gamData/savedPlayer.json") && userInput == "load")
            {
                Console.WriteLine("There is no saved Game."); 
                itemsString = readJSON.LoadObjects(orignalData[0]);
                npcItemsString = readJSON.LoadObjects(orignalData[1]);
                npcsString = readJSON.LoadObjects(orignalData[2]);
                areasString = readJSON.LoadObjects(orignalData[3]);
                playerString = readJSON.LoadObjects(orignalData[4]);
                Console.WriteLine("New Game has been loaded!");

            }
            
            else
            {
                itemsString = readJSON.LoadObjects(orignalData[0]);
                npcItemsString = readJSON.LoadObjects(orignalData[1]);
                npcsString = readJSON.LoadObjects(orignalData[2]);
                areasString = readJSON.LoadObjects(orignalData[3]);
                playerString = readJSON.LoadObjects(orignalData[4]);
                Console.WriteLine("New Game has been loaded!");
            }
            
            
            foreach (String[] elem in itemsString)
            {
                items.Add(new Item(elem[0], elem[1])); 
                //Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
            }

            foreach (String[] elem in npcItemsString)
            {
                npcItems.Add(new Item(elem[0], elem[1])); 
                //Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
            }

            for (int i = 0; i < npcsString.Count; i++)
            {
                int elem1 = int.Parse(npcsString[i][1]); 
                int elem2 = int.Parse(npcsString[i][2]);
                bool elem3 = bool.Parse(npcsString[i][3]); 
                bool elem4 = bool.Parse(npcsString[i][4]);

                List<Item> elem5 = new List<Item>();
                if (npcsString[i][5] != null) elem5.Add(npcItems[i]);

                npcs.Add(new NPC(npcsString[i][0], elem1, elem2, elem3, elem4, elem5, npcsString[i][6], npcsString[i][7]));
            }

            for (int i = 0; i < areasString.Count; i++)
            {
                List<Item> elem1 = new List<Item>();
                if (areasString[i][1] != null) elem1.Add(items[i]);

                NPC elem2 = null;
                if (areasString[i][2] != null) elem2 = npcs[i];
                bool elem5 = bool.Parse(areasString[i][5]);

                areas.Add(new Area(areasString[i][0], elem1, elem2, areasString[i][3], areasString[i][4], elem5));
            }

            foreach (String[] elem in playerString)
            {
                int elem1 = int.Parse(elem[1]); 
                int elem2 = int.Parse(elem[2]); 
                bool elem3 = bool.Parse(elem[3]); 
                bool elem4 = bool.Parse(elem[4]); 
                List<Item> elem5 = new List<Item>(); 

                player = new PlayerCharacter(elem[0], elem1, elem2, elem3, elem4, elem5); 
            }

            Commands commands = new Commands();

            start(items, npcs, areas, npcItems, player, commands);        
        }
    }
}
