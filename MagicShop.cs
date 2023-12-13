using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering3
{
    internal class MagicShop
    {
        private List<string> animals = new List<string> {"ugle", "rotte", "katt" };
        private List<string> wands = new List<string> {"Føniksstav", "unikornstav", "trollstav"};

        public string buyAnimal()
        {
            Console.WriteLine("Hvilket dyr vil du kjøpe?");
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }

            int choice = int.Parse(Console.ReadLine()); 
            return animals[choice - 1]; 
        }

        public string buyWands()
        {
            Console.WriteLine("Hvilken tryllestav vil du kjøpe?");
            for (int i = 0; i < wands.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {wands[i]}");
            }

            int choice = int.Parse(Console.ReadLine());
            return wands[choice - 1];

        }

    }
}