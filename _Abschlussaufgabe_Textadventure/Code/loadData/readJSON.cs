using System;
using System.Collections.Generic;

namespace Code
{
    class readJSON
    {
        public static List<String[]> LoadItems()
        {
            List<String[]> items = new List<String[]>();
            String itemString = parseJSONtoString.parseToString("gameData/item.json");
            List<String> itemList = splitObjects.splitObject(itemString);
            //Console.WriteLine(itemList);
            foreach (String elem in itemList)
            {
                items.Add(splitObjects.splitAttributes(elem));
            }
            return items;
        }

        public static List<String[]> LoadNPCs()
        {
            List<String[]> npcs = new List<String[]>();
            String npcString = parseJSONtoString.parseToString("gameData/npc.json");
            List<String> npcList = splitObjects.splitObject(npcString);
            //Console.WriteLine(npcList);
            foreach (String elem in npcList)
            {
                npcs.Add(splitObjects.splitAttributes(elem));
            }
            return npcs;
        }

        public static List<String[]> LoadAreas()
        {
            List<String[]> areas = new List<String[]>();
            String areaString = parseJSONtoString.parseToString("gameData/area.json");
            List<String> areaList = splitObjects.splitObject(areaString);
            //Console.WriteLine(areaList);
            foreach (String elem in areaList)
            {
                areas.Add(splitObjects.splitAttributes(elem));
            }
            return areas;
        }

        public static List<String[]> LoadNPCItems()
        {
            List<String[]> npcItems = new List<String[]>();
            String npcItemString = parseJSONtoString.parseToString("gameData/npcItem.json");
            List<String> npcItemList = splitObjects.splitObject(npcItemString);
            //Console.WriteLine(npcItemList);
            foreach (String elem in npcItemList)
            {
                npcItems.Add(splitObjects.splitAttributes(elem));
            }
            return npcItems;
        }

        public static List<String[]> LoadPlayerCharacter()
        {
            List<String[]> player = new List<String[]>();
            String playerString = parseJSONtoString.parseToString("gameData/player.json");
            List<String> playerList = splitObjects.splitObject(playerString);
            //Console.WriteLine(npcItemList);
            foreach (String elem in playerList)
            {
                player.Add(splitObjects.splitAttributes(elem));
            }
            return player;
        }
    }
}