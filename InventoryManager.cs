using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Dictionary<string, int> inventory = new Dictionary<string, int>();

    public void AddItem(string item, int amount)
    {
        if(inventory.ContainsKey(item))
        {
            inventory[item] += amount;
        }
        else
        {
            inventory.Add(item, amount);
        }
    }
    public void AddItem(string item)
    {
        AddItem(item, 1);
    }

    public bool RemoveItem(string item, int amount)
    {
        if (inventory.ContainsKey(item))
        {
            if(inventory[item] >= amount)
            {
                inventory[item] -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public bool RemoveItem(string item)
    {
        return RemoveItem(item, 1);
    }

    public int GetAmount(string item)
    {
        return inventory[item];
    }

    public void SetAmount(string item, int amount)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] = amount;
        }
        else
        {
            inventory.Add(item, amount);
        }
    }

    public Dictionary<string, int> GetInventory()
    {
        return inventory;
    }
}
