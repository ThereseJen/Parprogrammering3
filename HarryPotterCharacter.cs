using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering3
{
    internal class HarryPotterCharacter
    {
        public string Name { get; }
        public string House { get; }
        public List<string> InventoryList = new();

        public HarryPotterCharacter(string name, string house, List<string> inventoryArray)
        {
            Name = name;
            House = house;
            InventoryList = inventoryArray;
        }

        public void DisplayInventory()
        {
            foreach (var item in InventoryList)
            {
                Console.WriteLine(item);
            }
        }

        public void CastSpell()
        {
            Console.WriteLine("Skriv inn trylleformelen");
            var input = Console.ReadLine().ToLower();
           
            switch(input)
            {
                case "vingardium leviosa":
                    Console.WriteLine("Du har fått en fjær til å fly!");
                    break;

                case "hokus pokus":
                    Console.WriteLine("Fyrverkeri kommer ut fra staven din.");
                    break;
                case "avada kadavra":
                    Console.WriteLine("Oops...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ugyldig trylleformel.");
                    break;
            }
            
        }
    }
}
