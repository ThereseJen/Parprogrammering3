namespace Parprogrammering3
{
    internal class Program
    {
        static void Main()
        {
            HarryPotterCharacter character = new("Harry", "Griffing", ["føniksstav", "ugle"]);
            MagicShop magicShop = new MagicShop();


            Console.WriteLine($"{character.Name} er i i huset {character.House} og har: ");
            character.DisplayInventory();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Dine valgmuligheter:");
                Console.WriteLine("(1) Kjøpe dyr  (2) Kjøpe tryllestav  (3) Se på tingene dine  (4) Kaste trylleformel");
                var input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        var animal = magicShop.buyAnimal();
                        character.InventoryList.Add(animal);
                        break;

                    case ConsoleKey.D2:
                        var wand = magicShop.buyWands();
                        character.InventoryList.Add(wand);
                        break;

                    case ConsoleKey.D3:
                        character.DisplayInventory();
                        break;

                    case ConsoleKey.D4:
                        character.CastSpell();
                        break;

                    default:
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
