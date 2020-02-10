using System;
using System.Collections.Generic;

namespace Code
{
    class readJSON
    {
        public static List<String[]> LoadItems(string path)
        {
            List<String[]> items = new List<String[]>();
            String itemString = parseJSONtoString.parseToString(path);
            List<String> itemList = splitObjects.splitObject(itemString);
            //Console.WriteLine(itemList);
            foreach (String elem in itemList)
            {
                items.Add(splitObjects.splitAttributes(elem));
            }
            return items;
        }

        public static List<String[]> LoadNPCs(string path)
        {
            List<String[]> npcs = new List<String[]>();
            String npcString = parseJSONtoString.parseToString(path);
            List<String> npcList = splitObjects.splitObject(npcString);
            //Console.WriteLine(npcList);
            foreach (String elem in npcList)
            {
                npcs.Add(splitObjects.splitAttributes(elem));
            }
            return npcs;
        }

        public static List<String[]> LoadAreas(string path)
        {
            List<String[]> areas = new List<String[]>();
            String areaString = parseJSONtoString.parseToString(path);
            List<String> areaList = splitObjects.splitObject(areaString);
            //Console.WriteLine(areaList);
            foreach (String elem in areaList)
            {
                areas.Add(splitObjects.splitAttributes(elem));
            }
            return areas;
        }

        public static List<String[]> LoadNPCItems(string path)
        {
            List<String[]> npcItems = new List<String[]>();
            String npcItemString = parseJSONtoString.parseToString(path);
            List<String> npcItemList = splitObjects.splitObject(npcItemString);
            //Console.WriteLine(npcItemList);
            foreach (String elem in npcItemList)
            {
                npcItems.Add(splitObjects.splitAttributes(elem));
            }
            return npcItems;
        }

        public static List<String[]> LoadPlayerCharacter(string path)
        {
            List<String[]> player = new List<String[]>();
            String playerString = parseJSONtoString.parseToString(path);
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