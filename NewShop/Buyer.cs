using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    interface Buyer
    {
        void Buy(Salor salor, string itemName);
        float PayForItem(float price);
        void Display();
    }
}
