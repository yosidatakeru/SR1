using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RS9_2
{
    internal class Player 
    {
        Item item;
        public Player(Item name) 
        {
            this.item = name;
        }

       

        public void UseItem()
        {
           item.Use();
        }
    }
}
