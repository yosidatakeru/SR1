using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS9_2
{
    internal class Item
    {
        protected string name = "";
        public Item(string name)
        {
            this.name = name;
        }

        public void Use() 
        {
            Console.WriteLine("{0}を使用した", name);
        }
    }
}
