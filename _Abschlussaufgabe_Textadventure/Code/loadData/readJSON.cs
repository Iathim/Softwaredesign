using System;
using System.Collections.Generic;

namespace Code
{
    class readJSON
    {
        public static List<String[]> LoadObjects(String path)
        {
            List<String[]> objects = new List<String[]>();
            String objectString = parseJSONtoString.parseToString(path);
            List<String> objectList = splitObjects.splitOriginalObject(objectString);
            
            foreach (String elem in objectList)
            {
                objects.Add(splitObjects.splitOriginalAttributes(elem));
            }
            return objects;
        }

        public static List<String[]> LoadSavedObjects(String path)
        {
            List<String[]> objects = new List<String[]>();
            String objectString = parseJSONtoString.parseToString(path);
            List<String> objectList = splitObjects.splitSavedObject(objectString);

            foreach (String str in objectList)
            {
                //Console.WriteLine(str);
            }
            foreach (String elem in objectList)
            {
                objects.Add(splitObjects.splitSavedAttributes(elem));
            }
            return objects;
        }
    }
}