using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<int, int> items = new Dictionary<int, int>()
    {
        {7,12},
        {1,10},
    };

    public Dictionary<int, int> Items { get => items; set => items = value; }

    private void Start()
    {
        ShowInventory();
    }

    public void AddItem(int Id, int Amount)
    {
        if (!Items.ContainsKey(Id))
        {
            Items.Add(Id, Amount);
        }
        else
        {
            Items[Id] += Amount;
        }
        ShowInventory();
    }

    public void RemoveItem(int Id, int Amount)
    {
        if (Items.ContainsKey(Id))
        {
            Items[Id] -= Amount;
            if (Items[Id] <= 0)
            {
                Items.Remove(Id);
            }
        }
    }

    public void ShowInventory()
    {
        foreach (var item in Items)
        {
            Debug.Log(item);
        }
    }
}
