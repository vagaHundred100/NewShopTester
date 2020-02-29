using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    interface Salor
    {
        Item Sell(Buyer buyer, string itemName);
        void Display();
    }
}
