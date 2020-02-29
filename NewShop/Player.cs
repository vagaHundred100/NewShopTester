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
        private float _spendAmount = 0;

        public string Name { get; private set; }

        public Player(string name,float cash)
        {
            Name = name;
            _balance = cash;
        }
        public void Buy(Salor salor, string itemName)
        {
            Item boughtItem = salor.Sell(this, itemName);
            if (boughtItem != null)
            {
                _items.Add(boughtItem);
                _spendAmount = 0;
            }
            else
            {
                _balance += _spendAmount;
                _spendAmount = 0;
            }
        }

        public float PayForItem(float price)
        {
            float notSpend = -1;
            if(_balance >= price)
            {
                _balance -= price;
                _spendAmount += price;
                return price;
            }
            return notSpend;
        }

        public void Display()
        {
            foreach (Item item in _items)
            {
                Console.WriteLine("Player : My Items");
                item.Display();
            }
        }
    }
}
