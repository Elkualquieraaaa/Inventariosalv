using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemdataSO : ScriptableObject
{
    [SerializeField] int _Id;
    [SerializeField] string _Itemname;
    [SerializeField] Sprite _Sprite;
    [SerializeField] GameObject _Prefab;
}
