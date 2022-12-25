# Level 33 - "Packing Inventory"
Following along with the C# Player's Guide by RB Whitaker
## Criteria:
1. Create a InventoryItem class as a base class to represent items in the Pack. Must represent the following at creation (via constructor):
   2. weight
   3. volume
2. Create derived classes for each of the following items that pass weight and volume to the base class constructor. 
   3. Note - These should be creatable through a parameterless constructor (e.g. new Rope(), new Sword(), etc.)
      1. Arrow - weight: 1 / volume: 1.5
      2. Bow - weight: 1 / volume: 4
      3. Rope - weight: 1 / volume: 1.5
      4. Water - weight: 2 / volume: 3
      5. Food Rations - 1 / volume: 0.5
      6. Sword - weight: 5 / volume: 3
3. Make a Pack class that stores an array of items. Number of items, max weight, and max volume are set at creation and cannot be changed.
4. Make a public bool Add(InventoryItem item) method to Pack class. This allows addition of items of any type to pack. 
   5. Method should return false (fail) and not update field if adding item would exceed pack's item, weight, or volume limit
5. Add the following properties to Pack so the following can be reported on (must also report the limits of each):
   6. item count
   7. weight
   8. volume
9. Program should create a new pack and allows user to attempt to add items that are chosen from a menu
