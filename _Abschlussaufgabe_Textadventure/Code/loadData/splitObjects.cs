using System;
using System.Collections.Generic;

namespace Code
{
	class splitObjects
	{
		public static List<String> splitObject(String objectString)
		{	
			List<String> objects = new List<String>();

			//Console.WriteLine(itemString);

			String[] objectArray  = objectString.Split("},{");

			foreach (String obj in objectArray)
			{
				String cutObject = "";
				cutObject = obj.Replace("[{", "").Replace("}]", "");
				objects.Add(new String(cutObject));
				//Console.WriteLine(cutItem);
			}
			return objects;
		}

		//public static List<String> splitItem()
	}
}