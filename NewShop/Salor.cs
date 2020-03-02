using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    interface Salor
    {
        Item Sell(string itemName,float price);

        float GetItemPrice(string itemName);
        void Display();
    }
}
