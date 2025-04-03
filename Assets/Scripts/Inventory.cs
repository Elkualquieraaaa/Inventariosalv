using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<int, int> items = new Dictionary<int, int>()
    {
        {2,12},
        {1,10 }
    };

    private void Start()
    {
        ShowInventory();
    }

    public void AddItem(int Id, int Amount)
    {
        if (!items.ContainsKey(Id))
        {
            items.Add(Id, Amount);
        }
        else
        {
            items[Id] += Amount;
        }
        ShowInventory();
    }

    public void RemoveItem(int Id, int Amount)
    {
        if (items.ContainsKey(Id))
        {
            items[Id] -= Amount;
            if (items[Id] <= 0)
            {
                items.Remove(Id);
            }
        }
    }

    public void ShowInventory()
    {
        foreach (var item in items)
        {
            Debug.Log(item);
        }
    }
}
