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
        public Item Sell(Buyer buyer, string itemName)
        {
            if (Items.ContainsKey(itemName))
            {
                Item itemForSale = Items[itemName];
                float itemPrice = itemForSale.Price;
                float gettedMoney = buyer.PayForItem(itemPrice);
                if(gettedMoney >= itemForSale.Price)
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
    }
}
