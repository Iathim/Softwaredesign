using System;
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
            //Pfade zu den Originalen Dateien
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String[] orignalData = 
            {
                "gameData/originalData/item.json",
                "gameData/originalData/npcItem.json",
                "gameData/originalData/npc.json",
                "gameData/originalData/area.json",
                "gameData/originalData/player.json"        
            };
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            List<Item> items = new List<Item>(); 
            List<String[]> itemsString = readJSON.LoadItems(orignalData[0]);
            foreach (String[] elem in itemsString)
            {
                items.Add(new Item(elem[0], elem[1])); 
                //Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
            }

            List<Item> npcItems = new List<Item>(); 
            List<String[]> npcItemsString = readJSON.LoadNPCItems(orignalData[1]);
            foreach (String[] elem in npcItemsString)
            {
                npcItems.Add(new Item(elem[0], elem[1])); 
                //Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
            }

            List<NPC> npcs = new List<NPC>(); 
            List<String[]> npcsString = readJSON.LoadNPCs(orignalData[2]);
            for (int i = 0; i < npcsString.Count; i++)
            {
                int elem1 = int.Parse(npcsString[i][1]); 
                int elem2 = int.Parse(npcsString[i][2]);
                bool elem3 = bool.Parse(npcsString[i][3]); 
                bool elem4 = bool.Parse(npcsString[i][4]);

                List<Item> elem5 = new List<Item>();
                elem5.Add(npcItems[i]);

                npcs.Add(new NPC(npcsString[i][0], elem1, elem2, elem3, elem4, elem5, npcsString[i][6], npcsString[i][7]));
            }

            List<Area> areas = new List<Area>(); 
            List<String[]> areasString = readJSON.LoadAreas(orignalData[3]);
            for (int i = 0; i < areasString.Count; i++)
            {
                List<Item> elem1 = new List<Item>();
                elem1.Add(items[i]);

                NPC elem2 = npcs[i];
                bool elem5 = bool.Parse(areasString[i][5]);

                areas.Add(new Area(areasString[i][0], elem1, elem2, areasString[i][3], areasString[i][4], elem5));

            }

            PlayerCharacter player = null; 
            List<String[]> playerString = readJSON.LoadPlayerCharacter(orignalData[4]);
            foreach (String[] elem in playerString)
            {
                int elem1 = int.Parse(elem[1]); 
                int elem2 = int.Parse(elem[2]); 
                bool elem3 = bool.Parse(elem[3]); 
                bool elem4 = bool.Parse(elem[4]); 
                List<Item> elem5 = new List<Item>(); 

                player = new PlayerCharacter(elem[0], elem1, elem2, elem3, elem4, elem5); 
                
                /*Console.WriteLine("Name: {0}, HP: {1}, Damage: {2}, isDead: {3}, isPlayerCharacter: {4}, Inventory: {5}" ,
                    elem[0], elem[1], elem[2], elem[3], elem[4], elem[5]);*/
            }

            Commands commands = new Commands();
            start(items, npcs, areas, npcItems, player, commands);

            //Zu Testzwecken
            //Commands.saveGame(items, npcs, areas, npcItems, player);         
        }
    }
}
