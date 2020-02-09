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
            List<String[]> items = readJSON.LoadItems();
           foreach (String[] elem in items)
           {
               Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
           }
           Console.Write(Environment.NewLine);

           List<String[]> areas = readJSON.LoadAreas();
           foreach (String[] elem in areas)
           {
               Console.WriteLine("Description: {0}, Items: {1}, NPC: {2}, Type: {3}, Position: {4}" ,
                elem[0], elem[1], elem[2], elem[3], elem[4]);
           }
           Console.Write(Environment.NewLine);

           List<String[]> npcs = readJSON.LoadNPCs();
           foreach (String[] elem in npcs)
           {
               Console.WriteLine("Name: {0}, HP: {1}, Damage: {2}, isDead: {3}, isPlayerCharacter: {4}, Inventory: {5}, Dialogue: {6}" ,
                elem[0], elem[1], elem[2], elem[3], elem[4], elem[5], elem[6]);
           }
           Console.Write(Environment.NewLine);

           List<String[]> npcItems = readJSON.LoadNPCItems();
           foreach (String[] elem in npcItems)
           {
               Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
           }

           List<String[]> player = readJSON.LoadPlayerCharacter();
           foreach (String[] elem in player)
           {
               Console.WriteLine("Name: {0}, Description: {1}", elem[0], elem[1]);
           }
        }
    }
}
