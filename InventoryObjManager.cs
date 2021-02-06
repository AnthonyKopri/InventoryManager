using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjManager : MonoBehaviour
{
    public Dictionary<string, List<GameObject>> inventory = new Dictionary<string, List<GameObject>>();

    public void AddItem(string name, GameObject item, int amount)
    {
        if (inventory.ContainsKey(name))
        {
            for (int i = 0; i < amount; i++)
            {
                inventory[name].Add(item);
            }
        }
        else
        {
            inventory.Add(name, new List<GameObject>());

            for (int i = 0; i < amount; i++)
            {
                inventory[name].Add(item);
            }
        }
    }
    public void AddItem(string name, GameObject item)
    {
        AddItem(name, item, 1);
    }
    public void AddItem(GameObject item)
    {
        AddItem(item.GetComponent<ItemInfo>().type, item);
        //if (item.CompareTag("[SPECIFY TAG]"))
        //{
        //    AddItem(item.GetComponent<ItemInfo>().type, item);
        //}
        //else
        //{
        //    Debug.LogError("Unexpected Item Tag: " + item.tag);
        //}
    }

    public bool RemoveItem(string name, int amount)
    {
        if (inventory.ContainsKey(name))
        {
            if (inventory[name].Count >= amount)
            {
                for (int i = 0; i < amount; i++)
                {
                    inventory[name].RemoveAt(0);
                }
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
    public bool RemoveItem(string name)
    {
        return RemoveItem(name, 1);
    }
    
    public bool RemoveAll(string name)
    {
        if (inventory.ContainsKey(name))
        {
            inventory[name].Clear();
            return true;
        }
        else
        {
            return false;
        }
    }

    public void RemoveEverything()
    {
        inventory.Clear();
    }

    public List<GameObject> GetItem(string name, int amount, bool remove)
    {
        List<GameObject> temp = new List<GameObject>();

        if (inventory.ContainsKey(name))
        {
            if (inventory[name].Count >= amount)
            {
                for (int i = 0; i < amount; i++)
                {
                    temp.Add(inventory[name][i]);
                }
                if (remove)
                {
                    inventory[name].RemoveRange(0, amount);
                }
                return temp;
            }
        }
        return null;
    }
    public List<GameObject> GetItem(string name, int amount)
    {
        return GetItem(name, amount, true);
    }
    public GameObject GetItem(string name, bool remove)
    {
        if (inventory.ContainsKey(name))
        {
            if (inventory[name].Count > 0)
            {
                GameObject temp = new GameObject();
                temp = inventory[name][0];

                if (remove)
                {
                    inventory[name].RemoveAt(0);
                }

                return temp;
            }
            else
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }
    public GameObject GetItem(string name)
    {
        return GetItem(name, true);
    }

    public List<GameObject> GetAll(string name, bool remove)
    {
        List<GameObject> temp = new List<GameObject>();
        if (inventory.ContainsKey(name))
        {
            if(inventory[name].Count > 0)
            {
                temp = inventory[name];
                if (remove)
                    inventory[name].Clear();
                return temp;
            }
        }
        return null;
    }
    public List<GameObject> GetAll(string name)
    {
        return GetAll(name, true);
    }

    public List<GameObject> GetEverything(bool remove)
    {
        List<GameObject> temp = new List<GameObject>();

        foreach (List<GameObject> list in inventory.Values)
        {
            temp.AddRange(list);
        }
        if (remove)
            inventory.Clear();

        return temp;
    }
    public List<GameObject> GetEverything()
    {
        return GetEverything(true);
    }

    public int GetAmount(string name)
    {
        return inventory[name].Count;
    }

    public Dictionary<string,List<GameObject>> GetInventory()
    {
        return inventory;
    }
}
