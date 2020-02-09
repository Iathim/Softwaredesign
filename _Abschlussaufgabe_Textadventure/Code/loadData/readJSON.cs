using System;
using System.Collections.Generic;
//using Newtonsoft.Json;


namespace Code
{
    class readJSON
    {
        public static void LoadItems()
        {
            String itemString = parseJSONtoString.parseToString("gameData/item.json");
            List<String> itemList = splitObjects.splitObject(itemString);

            //Console.WriteLine(itemList);
        }
            /*


        String icao = null;
		String callsign = null;
		int species = 0;
		Date posTime = null;
		double longitude = 0;
		double latitude = 0;
		double speed = 0;
		double trak = 0;
		int altitude = 0;

		// Your code goese here
		String[] contents = sentence.aircraftSentence.split(",", 0);
		try 
		{
			icao = contents[0];
			icao = icao.replaceAll("\"", "");
		}
		catch(Exception e) { icao = "Unknown"; }
		try
		{
			callsign = contents[1];
			callsign = callsign.replaceAll("\"", "");
			callsign = callsign.replaceAll(" ", "");
		}
		catch(Exception e) {}
		species = 0; //Not provided
		try { posTime = new Date(TimeUnit.SECONDS.toMillis(Long.parseLong(contents[3]))); } catch(Exception e) {}
		try { longitude = Double.parseDouble(contents[5]); } catch(Exception e) {}
		try { latitude = Double.parseDouble(contents[6]); } catch(Exception e) {}
		try { speed = Double.parseDouble(contents[9]); } catch(Exception e) {}
		try { trak = Double.parseDouble(contents[10]); } catch(Exception e) {}
		try { altitude = (int) Float.parseFloat(contents[13]); } catch(Exception e) {}
		
		BasicAircraft msg = new BasicAircraft(icao, callsign, species, posTime, new Coordinate(latitude, longitude), speed, trak, altitude);
		
		return msg;
            }
            */
    }
}