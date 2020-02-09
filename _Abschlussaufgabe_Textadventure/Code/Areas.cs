using System;
using System.Collections.Generic; 

namespace Code
{
    public class Area
    {
        public string description;  
        public List<Item> items;
        public NPC NPC; 
        public string type; 
        public string position;
        public bool isActualArea;   

        public Area (string _description, List<Item> _items, NPC _NPC, string _type, string _position, bool _isActualArea)
        {
            this.description = _description; 
            this.items = _items; 
            this.NPC = _NPC; 
            this.type = _type;
            this.position = _position;
            this.isActualArea = _isActualArea; 
        }
    }
}
