using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        public static void start(PlayerCharacter character, Area[] areas, Commands commands)
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

                commands.useCommands(character, actualArea, areas, commands); 
            }
        }
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>(); 
            List<String[]> itemsString = readJSON.LoadItems();
           foreach (String[] elem in itemsString)
           {
               items.Add(new Item(elem[0], elem[1])); 
               //Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
           }
           Console.Write(Environment.NewLine);


            List<Area> areas = new List<Area>(); 
           List<String[]> areasString = readJSON.LoadAreas();
           foreach (String[] elem in areasString)
           {
               List<Item> elem1 = new List<Item>(); 
               NPC elem2 = null; 
                bool elem5 = bool.Parse(elem[5]); 

               areas.Add(new Area(elem[0], elem1, elem2, elem[3], elem[4], elem5)); 
               
               Console.WriteLine("Description: {0}, Items: {1}, NPC: {2}, Type: {3}, Position: {4}, IsActualArea: {5}" ,
                elem[0], elem[1], elem[2], elem[3], elem[4], elem[5]);
           }
           Console.Write(Environment.NewLine);


            List<NPC> npcs = new List<NPC>(); 
           List<String[]> npcsString = readJSON.LoadNPCs();
           foreach (String[] elem in npcsString)
           {
               int elem1 = int.Parse(elem[1]); 
               int elem2 = int.Parse(elem[2]); 
               bool elem3 = bool.Parse(elem[3]); 
               bool elem4 = bool.Parse(elem[4]); 
               List<Item> elem5 = new List<Item>(); 

               npcs.Add(new NPC(elem[0], elem1, elem2, elem3, elem4, elem5, elem[6], elem[7])); 

               Console.WriteLine("Name: {0}, HP: {1}, Damage: {2}, isDead: {3}, isPlayerCharacter: {4}, Inventory: {5}, Dialogue: {6}" ,
                elem[0], elem[1], elem[2], elem[3], elem[4], elem[5], elem[6]);
           }
           Console.Write(Environment.NewLine);


            List<Item> npcItems = new List<Item>(); 
           List<String[]> npcItemsString = readJSON.LoadNPCItems();
           foreach (String[] elem in npcItemsString)
           {
               npcItems.Add(new Item(elem[1], elem[2])); 
               Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
           }


            PlayerCharacter player = null; 
           List<String[]> playerString = readJSON.LoadPlayerCharacter();
           foreach (String[] elem in playerString)
           {
               int elem1 = int.Parse(elem[1]); 
               int elem2 = int.Parse(elem[2]); 
               bool elem3 = bool.Parse(elem[3]); 
               bool elem4 = bool.Parse(elem[4]); 
               List<Item> elem5 = new List<Item>(); 

               player = new PlayerCharacter(elem[0], elem1, elem2, elem3, elem4, elem5); 
               //player.Add(new PlayerCharacter(elem[0], elem1, elem2, elem3, elem4, elem5)); 
               
               Console.WriteLine("Name: {0}, HP: {1}, Damage: {2}, isDead: {3}, isPlayerCharacter: {4}, Inventory: {5}" ,
                elem[0], elem[1], elem[2], elem[3], elem[4], elem[5]);
           }
        }
    }
}
