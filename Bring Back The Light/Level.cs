using System;
using System.Collections.Generic;
using System.Text;

namespace Bring_Back_The_Light
{
    //i copied "list" code from our class restaurant game
    public class Level
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Stars { get; set; }

        public List<Collectibles> Collectibles { get; set; } = new List<Collectibles>();


    }
}
