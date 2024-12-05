using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SR9_1
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
