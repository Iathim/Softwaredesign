using System;
using System.Collections.Generic; 

namespace Code
{
    public class Area
    {
        public string Description;  
        public List<Item> Items;
        public NPC NPC; 
        public string Type; 
        public string Position;
        public bool IsActualArea;   

        public Area (string _description, List<Item> _items, NPC _NPC, string _type, string _position, bool _isActualArea)
        {
            this.Description = _description; 
            this.Items = _items; 
            this.NPC = _NPC; 
            this.Type = _type;
            this.Position = _position;
            this.IsActualArea = _isActualArea; 
        }
    }
}
