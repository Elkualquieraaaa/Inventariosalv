using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<int, int> items = new Dictionary<int, int>()
    {
        {7,12},
        {1,10},
        {2,20},
        {3,30},
    };
    public delegate void Inventorydelegates();
    public Inventorydelegates itemremove;
    public Inventorydelegates itemupdate;
    public Inventorydelegates itemadd;

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
            itemadd?.Invoke();
        }
        else
        {
            Items[Id] += Amount;
            itemupdate?.Invoke();
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
                itemremove?.Invoke();
            }
            else
            {
                itemupdate?.Invoke();
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
