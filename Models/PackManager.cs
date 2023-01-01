namespace _033_packing_inventory.Models;

public class PackManager
{
    public void Start()
    {
        // Menu for user selection
        Console.WriteLine("Items available to add to pack:");
        Console.WriteLine("1. Arrow");
        Console.WriteLine("2. Bow");
        Console.WriteLine("3. Rope");
        Console.WriteLine("4. Water");
        Console.WriteLine("5. Food Rations");
        Console.WriteLine("6. Sword");

        // Create new Pack instance object
        Pack pack = new Pack();

        // Loop through to put as many items in our pack as possible
        for (int i = 0; i < pack.PackItems.Length; i++)
        {
            Console.Write("Please enter the number of the item you'd like to add to your pack:");
            string? selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    pack.Add(new PackItems.Arrow(), i);
                    pack.CurrentNumberItems++;
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }
            
            DisplayPackStatus(pack);
        }
    }

    public void DisplayPackStatus(Pack pack)
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Number of item slots remaining: {pack.PackItems.Length - pack.CurrentNumberItems}");
        Console.WriteLine($"Current weight of items in pack: {pack.CurrentWeight}");
        Console.WriteLine($"Current volume of items in pack: {pack.CurrentVolume}");
    }
}