using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Inventory
    {
        public Item [] Items { get; set; }

        public int Capacity { get { return (Items == null) ? 0 : Items.Length; } }

        public Inventory(int storage = 10)
        {
            SizeOfInventory(storage); 
        }

        public void  SizeOfInventory(int cap)
        {
            
        }
    
    }
}
