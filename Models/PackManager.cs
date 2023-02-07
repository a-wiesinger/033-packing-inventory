namespace _033_packing_inventory.Models;

public class PackManager
{
    public void ManageGame()
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
        
        // Index for adding item in pack array
        int packArrayIndex = 0;

        // Loop through to put as many items in our pack as possible
        while (true)
        {
            if (pack.CurrentNumberItems >= Pack.MaxNumberItems) break;
            if (pack.CurrentWeight >= pack.MaxWeight) break;
            if (pack.CurrentVolume >= pack.MaxVolume) break;
            
            Console.Write("Please enter the number of the item you'd like to add to your pack:");

            string? selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    if (pack.Add(new PackItems.Arrow(), packArrayIndex))
                    {
                        pack.CurrentNumberItems++;
                        packArrayIndex++;
                    }
                    break;
                case "2":
                    if (pack.Add(new PackItems.Bow(), packArrayIndex))
                    {
                        pack.CurrentNumberItems++;
                        packArrayIndex++;
                    }
                    break;
                case "3":
                    if (pack.Add(new PackItems.Rope(), packArrayIndex))
                    {
                        pack.CurrentNumberItems++;
                        packArrayIndex++;
                    }
                    break;
                case "4":
                    if (pack.Add(new PackItems.Water(), packArrayIndex))
                    {
                        pack.CurrentNumberItems++;
                        packArrayIndex++;
                    }
                    break;
                case "5":
                    if (pack.Add(new PackItems.FoodRations(), packArrayIndex))
                    {
                        pack.CurrentNumberItems++;
                        packArrayIndex++;
                    }
                    break;
                case "6":
                    if (pack.Add(new PackItems.Sword(), packArrayIndex))
                    {
                        pack.CurrentNumberItems++;
                        packArrayIndex++;
                    }
                    break;
                default:
                    break;
            }
            
            DisplayPackStatus(pack);
        }

        DisplayEndingPackStats(pack);
    }

    public void DisplayPackStatus(Pack pack)
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Pack contents: {pack.ToString()}");
        Console.WriteLine($"Number of item slots remaining: {pack.PackItems.Length - pack.CurrentNumberItems}");
        Console.WriteLine($"Current weight of items in pack: {pack.CurrentWeight}");
        Console.WriteLine($"Current volume of items in pack: {pack.CurrentVolume}");
    }

    public void DisplayEndingPackStats(Pack pack)
    {
        Console.Clear();
        
        Console.WriteLine("*******************************************************");
        Console.WriteLine("Final Pack Info");
        Console.WriteLine("*******************************************************");
        Console.WriteLine($"Final pack contents: {pack.ToString()}");
        Console.WriteLine($"Number of item slots used: {pack.CurrentNumberItems} out of {Pack.MaxNumberItems}");
        Console.WriteLine($"Weight of items in pack: {pack.CurrentWeight}");
        Console.WriteLine($"Volume of items in pack: {pack.CurrentVolume}");
    }
}