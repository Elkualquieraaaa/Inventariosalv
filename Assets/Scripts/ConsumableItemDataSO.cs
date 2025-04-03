using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ConsumableTypeEnum
{
    Heal,
    Damage
}

[CreateAssetMenu(fileName = "Consumable SO", menuName = "Consmumable SO")]
public class ConsumableItemData : ItemdataSO
{
    [SerializeField]ConsumableTypeEnum type;
    [SerializeField]int value;

}
