using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_WPF_St_208
{
    class MenuItem
    {
        public Random Randomizer = new Random();

        public string[] Proteins = {" Roast beef ", " Salami ", " Turkey ", " Ham ", " Pasreami ", " Tofu " };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = {"rye","white","wheat","pumpernickel", "a roll" };

        public string Description = "";
        public string Price;



        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiments = Proteins[Randomizer.Next(Condiments.Length)];
            string randomBreads = Proteins[Randomizer.Next(Breads.Length)];

            Description = randomProtein + " with " + randomCondiments + " on " + randomBreads;
            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1,98);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
            

        }
    }
}
