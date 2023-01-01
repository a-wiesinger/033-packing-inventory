namespace _033_packing_inventory.Models;

public class Pack
{
    private static int MaxNumberItems { get; set; } = 5;
    public int MaxWeight { get; set; } = 30;
    public float MaxVolume { get; set; } = 5f;
    
    public int CurrentNumberItems { get; set; }
    public int CurrentWeight { get; set; }
    public float CurrentVolume { get; set; }
    
    public InventoryItem[] PackItems { get; set; } = new InventoryItem[MaxNumberItems];

    // Attempt to add items to the pack
    public bool Add(InventoryItem item)
    {
        if (item.Weight + CurrentWeight > MaxWeight || item.Volume + CurrentVolume > MaxVolume)
        {
            Console.WriteLine("*** Sorry, that won't fit ***");
            return false;
        }

        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;

        PackItems.Append(item);
        return true;
    }
}