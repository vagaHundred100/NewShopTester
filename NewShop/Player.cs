using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    class Player : Buyer
    {
        private List<Item> _items = new List<Item>();
        private float _balance = 0;

        public string Name { get; private set; }

        public Player(string name,float cash)
        {
            Name = name;
            _balance = cash;
        }

        public bool PayForItem(float price)
        {
            bool isPaid = false;
            if(_balance >= price)
            {
                _balance -= price;
                isPaid = true;
            }
            return isPaid;
        }

        public void Display()
        {
            foreach (Item item in _items)
            {
                Console.WriteLine("Player : My Items");
                item.Display();
            }
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }
    }
}
