namespace _033_packing_inventory.Models;

public class PackManager
{
    public void Start()
    {
        PackItems.Arrow arrow = new PackItems.Arrow();
        
        Console.WriteLine(arrow.Weight);
        Console.WriteLine(arrow.Volume);

    }
}