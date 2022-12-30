namespace _033_packing_inventory.Models;

public class PackItems
{
    public class Arrow : InventoryItem
    {
        public Arrow() : base(1, 1.5f)
        {

        }
    }

    public class Bow : InventoryItem
    {
        public Bow() : base(1, 4f)
        {
            
        }
    }
    
    public class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5f)
        {
            
        }
    }
    
    public class Water : InventoryItem
    {
        public Water() : base(2, 3f)
        {
            
        }
    }
    
    public class FoodRations : InventoryItem
    {
        public FoodRations() : base(1, 0.5f)
        {
            
        }
    }
    
    public class Sword : InventoryItem
    {
        public Sword() : base(5, 3f)
        {
            
        }
    }
}
