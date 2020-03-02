using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    class ItemSalor : Salor
    {
        public Dictionary<string, Item> Items { get; private set; }

        public ItemSalor()
        {
            Items = new Dictionary<string, Item>();
        }

        public Item Sell(string itemName,float price)
        {
            if (Items.ContainsKey(itemName))
            {
                Item itemForSale = Items[itemName];
                float itemPrice = itemForSale.Price;
                if(price >= itemForSale.Price)
                {
                    return itemForSale;
                }
                return null;
            }
            return null;
        }

        public void AddItem(Item newItem)
        {
            Items.Add(newItem.Name, newItem);
        }

        public void Display()
        {
            Console.WriteLine("ItemSalor : My Items");
            foreach(Item item in Items.Values)
            {
                item.Display();
            }
        }

        public float GetItemPrice(string itemName)
        {
            float notPaid = -1;
            if (Items.ContainsKey(itemName))
            {
                return Items[itemName].Price;
            }
            return notPaid;
        }
    }
}
