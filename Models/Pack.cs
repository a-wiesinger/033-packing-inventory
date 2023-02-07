namespace _033_packing_inventory.Models;

public class Pack
{
    public static int MaxNumberItems { get; set; } = 5;
    public int MaxWeight { get; set; } = 30;
    public float MaxVolume { get; set; } = 7f;
    
    public int CurrentNumberItems { get; set; }
    public int CurrentWeight { get; set; }
    public float CurrentVolume { get; set; }
    
    public InventoryItem[] PackItems { get; set; } = new InventoryItem[MaxNumberItems];

    // Attempt to add items to the pack
    public bool Add(InventoryItem item, int arrayIndex)
    {
        if (item.Weight + CurrentWeight > MaxWeight || item.Volume + CurrentVolume > MaxVolume)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*** Sorry, that won't fit. Try again. ***");
            Console.WriteLine("*****************************************");
            return false;
        }

        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;

        PackItems[arrayIndex] = item;
        return true;
    }

    public override string ToString()
    {
        string packContents = "";
        foreach (var item in PackItems)
        {
            if (item != null)
            {
                packContents += " " + item.ToString();
            }
        }
        return packContents;
    }
}