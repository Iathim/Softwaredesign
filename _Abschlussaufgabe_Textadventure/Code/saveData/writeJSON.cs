using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Code
{
    class writeJSON
    {
        public static void saveData<T>(List<T> objects, String path)
        {
            String _data = "";
            _data = JsonConvert.SerializeObject(objects);
            //Console.WriteLine(_data);
            
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _data);
            }
        }
    }
}