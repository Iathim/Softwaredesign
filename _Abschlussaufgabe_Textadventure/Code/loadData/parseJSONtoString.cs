using System;
using System.IO;

namespace Code
{
    class parseJSONtoString
    {
        public static String parseToString(String path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                String json = r.ReadToEnd();
                //json = json.Replace("\r", "").Replace("\n", "").Replace(" ", "").Replace("\"", "");
                json = json.Replace("\r", "").Replace("\n", "").Replace("\"", "");
                //Console.WriteLine(json);
                return json;
            }
        }
    }
}