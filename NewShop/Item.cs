using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    class Item
    {
        public float Price { get; private set; }
        public string Name { get; private set; }

        public Item(string name,float price)
        {
            Price = price;
            Name = name;
        }

        internal void Display()
        {
            Console.WriteLine("\nname : " + Name);
            Console.WriteLine("price : " + Price.ToString());
        }
    }
}
