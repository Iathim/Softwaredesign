using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Code
{
	class splitObjects
	{
		public static List<String> splitOriginalObject(String objectString)
		{	
			List<String> objects = new List<String>();

			//Console.WriteLine(itemString);

			String[] objectArray  = objectString.Split("},{");

			foreach (String obj in objectArray)
			{
				String cutObject = "";
				cutObject = obj.Replace("[{", "").Replace("}]", "").Replace("\\", "");
				objects.Add(new String(cutObject));
				//Console.WriteLine(cutItem);
			}
			return objects;
		}

		public static List<String> splitSavedObject(String objectString)
		{	
			//Console.WriteLine(objectString);
			List<String> objects = new List<String>();
			String[] objectArray  = objectString.Split("],[");

			foreach (String obj in objectArray)
			{
				String cutObject = "";
				cutObject = obj.Replace("[[", "").Replace("]]", "").Replace("\\", "");
				objects.Add(new String(cutObject));
				//Console.WriteLine(cutObject);
			}
			return objects;
		}

		public static String[] splitOriginalAttributes(String obj)
		{
			List<String> attributeList = new List<String>();
			String[] attributes = obj.Split(",");
			

			for (int i = 0; i < attributes.Length; i++)
			{
				String[] temp = attributes[i].Split(":");
				attributes[i] = temp[1];
			}

			return attributes;
		}

		public static String[] splitSavedAttributes(String obj)
		{
			List<String> attributeList = new List<String>();
			String[] attributes = obj.Split(",");

			return attributes;
		}

	}
}