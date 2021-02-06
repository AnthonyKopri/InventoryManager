# InventoryManager
Easy inventory manager script to create and manage inventory

**To implement the manager correctly, please make sure:**
- Add ItemInfo.cs script to items you want to be picked.
- Change "type" string in ItemInfo.cs to the type of the item.
- Insert the variaton of the inventory manager script you find useful to the game object you want to add an inventory.

## InventoryManager.cs
This is a text based inventory manager. It is mostly to keep track of items that you dont want to re-summon but rather keep it as a value.

1. `public void AddItem(string item, int amount)`
   - Adds amount specified to the `inventory[item]` slot. If the inventory dictionary doesn't have an entry for the item, then it creates a new entry with the `item` as the key and `amount` as the value.
  
2. `public void AddItem(string item)`
   - Overrides `AddItem(string item, int amount)` and functions as `AddItem(string item, 1)`.
  
3. `public bool RemoveItem(string item, int amount)`
   - Subtracts `amount` from the `inventory[item]`
   - If the key `item` does not exist, or contains value smaller than `amount`, returns `false` and does nothing.
   - If all the conditions are met, function subtracts the amount from said entry and returns `true`.
  
4. `public bool RemoveItem(string item)`
   - Overrides `RemoveItem(string item, int amount)` and functions as `RemoveItem(string item, 1)`.

5. `public int GetAmount(string item)`
   - Returns the int value of `inventory[item]`.
  
6. `public void SetAmount(string item, int amount)`
   - Sets amount specified to the `inventory[item]` slot. If the inventory dictionary doesn't have an entry for the item, then it creates a new entry with the `item` as the key and `amount` as the value.

7. `public Dictionary<string, int> GetInventory()`
   - Returns the Dictionary that contains the inventory.

## InventoryObjManager.
This is a GameObject based manager. It keeps track of the GameObjects and re-summons them at will. 

### More syntax and function info will be added.
