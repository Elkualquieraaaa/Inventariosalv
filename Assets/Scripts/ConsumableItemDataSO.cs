using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Consumable SO", menuName = "New Consmumable SO")]
public class ConsumableItemData : ItemdataSO
{
    public enum ConsumableTypeEnum
    { 
        Heal,
        Damage
    }

    ConsumableTypeEnum type;

    int value;

}
