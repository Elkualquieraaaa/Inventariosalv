using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataBase SO", menuName = "New DataBase SO")]

public class ItemDataBaseSO : ScriptableObject
{
    [SerializeField] List<ItemdataSO> Items;

    public List<ItemdataSO> Items1 { get => Items; set => Items = value; }

    public ItemdataSO SearchItemByID(int Id)
    {
        return Items.Find(x => x.Id == Id);
    }


}

