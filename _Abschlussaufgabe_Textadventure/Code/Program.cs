using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items1 = new List<Item>(); 
            items1.Add(new Item("Banana", "Fruit"));

            List<Item> items2 = new List<Item>(); 
            items2.Add(new Item ("Apple", "Fruit")); 

            List<Item> items3 = new List<Item>(); 
            items3.Add(new Item ("Mango of the devil", "Fruit")); 
            
            List<Item> items4 = new List<Item>(); 
            items4.Add(new Item ("Grape", "Fruit")); 

            List<Item> items5 = new List<Item>(); 
            items5.Add(new Item ("Pear", "Fruit")); 


            List<Item> npcItem1 = new List<Item>(); 
            npcItem1.Add(new Item("Weapon", "Does Boom!")); 

            List<Item> npcItem2 = new List<Item>(); 
            npcItem2.Add(new Item("Knife", "Doesn't Boom!")); 

            List<Item> npcItem3 = new List<Item>(); 
            npcItem3.Add(new Item("Pickle", "Wtf?")); 

            List<Item> npcItem4 = new List<Item>(); 
            npcItem4.Add(new Item("Lamp", "Does light!")); 

            List<Item> npcItem5 = new List<Item>(); 
            npcItem5.Add(new Item("Stick", "May as well be a straw!"));


            NPC nPC1 = new NPC("Hans", 20, 2, false, false, npcItem1, "Haha I'm evil.");
            NPC nPC2 = new NPC("Kans", 20, 2, false, false, npcItem2, "Haha."); 
            NPC nPC3 = new NPC("Sans", 20, 2, false, false, npcItem3, "OI!"); 
            NPC nPC4 = new NPC("Fans", 20, 2, false, false, npcItem4, "Whot."); 
            NPC nPC5 = new NPC("Lans", 20, 2, false, false, npcItem5, "Banana!");  

            Area areaN = new Area("Grün", items1, nPC1, "normal", "n"); 
            Area areaE = new Area("Rot", items2, nPC2, "normal", "e");
            Area areaS = new Area("Blau", items3, nPC3, "normal", "s");
            Area areaW = new Area("Lila", items4, nPC4, "normal", "w");
            Area areaM = new Area("Gelb", items5, nPC5, "normal", "m");

            Area[] areas = null; 
            areas[0] = areaM; 
            areas[1] = areaN; 
            areas[2] = areaE; 
            areas[3] = areaW; 
            areas[4] = areaS; 

            Area actualArea = areaM;  

            PlayerCharacter player = new PlayerCharacter("MainDude", 100, 20, false, true, null);

            Commands commands = new Commands("commands(c), look(l), move (m), talk to NPC (talk), inventory(i), take item(take), drop item(d), save(s), quit(q)"); 

            Commands.useCommands(player, actualArea, areas, commands); 
        }
    }
}
