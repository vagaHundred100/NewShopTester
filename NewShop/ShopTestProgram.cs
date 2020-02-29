using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop
{
    class ShopTestProgram
    {
        public static void Main(String[] arg) 
        {
            Item sword = new Item("Rat Killer", 200);
            Item shild = new Item("Djamalunga", 150);
            Item poisen = new Item("Best Fiance Killer", 500);

            ItemSalor Axmed = new ItemSalor();
            Axmed.AddItem(sword);
            Axmed.AddItem(shild);
            Axmed.AddItem(poisen);

            Player Vasya = new Player("Vasya", 600);

            Console.WriteLine("Welcome to the shop customer");
            Console.WriteLine("Look at my goods");
            Axmed.Display();
            Console.WriteLine("Presss the order of good ");
            int itemOrder = Convert.ToInt32(Console.ReadLine());

            switch (itemOrder)
            {
                case 1: 
                    Vasya.Buy(Axmed, "Rat Killer");
                    break;
                case 2:
                    Vasya.Buy(Axmed, "Djamalunga");
                    break;
                case 3:
                    Vasya.Buy(Axmed, "Best Fiance Killer");
                    break;
                default:
                    Console.WriteLine("Sorry we dont sell such item");
                    break;
            }
        }
        
    }
}
