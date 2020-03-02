using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    interface Buyer
    {
        void Add(Item item);
        bool PayForItem(float price);
        void Display();
    }
}
