# InventoryManager
Easy inventory manager script to create and manage inventory

**To implement the manager correctly, please make sure:**
- Add ItemInfo.cs script to items you want to be picked.
- Change "type" string in ItemInfo.cs to the type of the item.
- Insert the variaton of the inventory manager script you find useful to the game object you want to add an inventory.
---
---
## InventoryManager.cs
This is a text based inventory manager. It is mostly to keep track of items that you dont want to re-summon but rather keep it as a value.

1. **`void AddItem(string item, int amount)`**
   - Adds amount specified to the `inventory[item]` slot. If the inventory dictionary doesn't have an entry for the item, then it creates a new entry with the `item` as the key and `amount` as the value.
  ---
2. **`void AddItem(string item)`**
   - Overrides `AddItem(string item, int amount)` and functions as `AddItem(string item, 1)`.
  ---
3. **`bool RemoveItem(string item, int amount)`**
   - Subtracts `amount` from the `inventory[item]`
   - If the key `item` does not exist, or contains value smaller than `amount`, returns `false` and does nothing.
   - If all the conditions are met, function subtracts the amount from said entry and returns `true`.
  ---
4. **`bool RemoveItem(string item)`**
   - Overrides `RemoveItem(string item, int amount)` and functions as `RemoveItem(string item, 1)`.
  ---
5. **`int GetAmount(string item)`**
   - Returns the int value of `inventory[item]`.
  ---
6. **`void SetAmount(string item, int amount)`**
   - Sets amount specified to the `inventory[item]` slot. If the inventory dictionary doesn't have an entry for the item, then it creates a new entry with the `item` as the key and `amount` as the value.
  ---
7. **`Dictionary<string, int> GetInventory()`**
   - Returns the Dictionary that contains the inventory.
---
---
## InventoryObjManager.cs
This is a GameObject based manager. It keeps track of the GameObjects and re-summons them at will. 

1. **`void AddItem(string name, GameObject item, int amount)`**
   - Adds the `item` GameObject to the List `inventory[name]` , `amount` of times.
   - If the List `inventory[name]` does not exist, it creates a new List with the `item` added to it `amount` of times.
  ---
2. **`void AddItem(string name, GameObject item)`**
   - Overrides `AddItem(string name, GameObject item, int amount)` and functions as `AddItem(string name, GameObject item, 1)`.
  ---
3. **`void AddItem(GameObject item)`**
   - Overrides `AddItem(string name, GameObject item, int amount)`.
   - Gets the `name` attached to `item` (specified in ItemInfo.cs script) and functions as `AddItem(string name, GameObject item, 1)`.
  ---
4. **`bool RemoveItem(string name, int amount)`**
    - Removes the top element (index: 0) of the List `inventory[name]` , `amount` of times.
    - If the list doesn't exist or does not contain enough elements to remove, then does nothing and returns `false`.
    - If the list exists and has enough elements to remove, then removes the elements and returns `true`.
  ---
5. **`bool RemoveItem(string name)`**
   - Overrides `RemoveItem(string name, int amount)` and functions as `RemoveItem(string name, 1)`.
  ---
6. **`bool RemoveAll(string name)`**
   - Removes every element of the List `inventory[name]` and returns true.
   - If the list doesn't exist, then returns false.
  ---
7. **`void RemoveEverything()`**
   - Clears the Dictionary `inventory`.
  ---
8. **`List<GameObject> GetItem(string name, int amount, bool remove)`**
   - Returns a List of GameObjects in `inventory[name]` starting from index 0 to index `amount - 1`.
   - If the list is empty or contains less items than `amount` specified, returns `null`.
   - If the key `name` does not exist in the inventory, returns `null`.
   - If `remove` is set to true, items that are included in the returning list, are deleted from the inventory. This function makes it so if the script uses this function, it will not let duplicate items remain in the inventory.
  ---
9. **`List<GameObject> GetItem(string name, int amount)`**
   - Overrides GetItem(string name, int amount, bool remove) and returns GetItem(string name, int amount, true).
  ---
10. **`GameObject GetItem(string name, bool remove)`**
    - Returns the GameObject with index 0 in the List `inventory[name]`.
    - If the list is empty, returns `null`.
    - If the key `name` does not exist in inventory, returns `null`.
    - If `remove` is set to true, item that is returned, is deleted from the inventory. This function makes it so if the script uses this function, it will not let duplicate items remain in the inventory.
  ---
11. **`GameObject GetItem(string name)`**
    - Overrides GetItem(string name, bool remove) and returns GetItem(string name, true).
  ---
12. **`List<GameObject> GetAll(string name, bool remove)`**
    - Returns a List containing all GameObjects in `inventory[item]`.
    - If the list is empty, returns `null`.
    - If the key `name` does not exist in inventory, returns `null`.
    - If `remove` is set to true, the list stored in inventory is cleared. This function makes it so if the script uses this function, it will not let duplicate items remain in the inventory.
  ---
13. **`List<GameObject> GetAll(string name)`**
    - Overrides GetAll(string name, bool remove) and returns GetAll(string name, true).
  ---
14. **`List<GameObject> GetEverything(bool remove)`**
    - Returns a List of every GameObject stored in inventory.
    - If 'remove' is set to true, then the inventory dictionary is cleared.
  ---
15. **`List<GameObject> GetEverything()`**
    - Overrides GetEverything(bool remove) and returns GetEverything(true).
  ---
16. **`int GetAmount(string name)`**
    - Returns the amount of GameObjects stored in the `inventory[name]`.
  ---
17. **`Dictionary<string,List<GameObject>> GetInventory()`**
    - Returns the inventory dictionary as a whole.
---
---
### If you have any suggestions, please let me know.