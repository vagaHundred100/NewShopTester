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
            List<Item> items = new List<Item>
            {
                sword,shild,poisen
            };

            ItemSalor Axmed = new ItemSalor();
            Axmed.AddItem(sword);
            Axmed.AddItem(shild);
            Axmed.AddItem(poisen);

            Player Vasya = new Player("Vasya", 600);

            Console.WriteLine("Welcome to the shop customer");
            Console.WriteLine("Look at my goods");
            Axmed.Display();
            Console.WriteLine("Presss the name of good ");
            string itemName =Console.ReadLine();


            Vasya.Buy(Axmed, itemName);
            
 
        }
        
    }
}

