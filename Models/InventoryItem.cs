namespace _033_packing_inventory.Models;

public class InventoryItem
{
    public int Weight { get; set; }
    public float Volume { get; set; }

    public InventoryItem(int weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}