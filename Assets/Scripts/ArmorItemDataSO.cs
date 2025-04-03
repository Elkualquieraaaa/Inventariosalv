using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ArmaTypeEnum
{
    Head,
    Chest,
    Legs,
    feet,
}
[CreateAssetMenu(fileName = "Armor SO", menuName = "New Armor SO")]

public class ArmorItemDataSO : ItemdataSO
{
    [SerializeField] ArmaTypeEnum type;
    [SerializeField] int value;
}
