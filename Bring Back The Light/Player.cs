using System;
using System.Collections.Generic;
using System.Text;

namespace Bring_Back_The_Light
{
    public class Player
    {
        public string Name { get; set; } 

        public string Preference { get; set; }



        public string Race { get; set; }

        public int Hearts = 3;

        public List<Collectibles> Inventory { get; set; } = new List<Collectibles>();

        public void AddCollectiblesToInventory(Collectibles collectibles)
        {

            //if (Inventory.Contains(collectibles))
            //{
            //    Console.WriteLine($"Looks like you already have this item {collectibles.Name} in your inventory");
            //}
            //else
            //{
                Inventory.Add(collectibles);
                Console.WriteLine($"You collected letter {collectibles.Name}.");
            //}

        }

    }
}
