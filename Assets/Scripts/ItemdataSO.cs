using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemdataSO : ScriptableObject
{
    [SerializeField] int _Id;
    [SerializeField] string _Itemname;
    [SerializeField] Sprite _Sprite;
    [SerializeField] GameObject _Prefab;

    public int Id { get => _Id; set => _Id = value; }
    public string Itemname { get => _Itemname; set => _Itemname = value; }
    public Sprite Sprite { get => _Sprite; set => _Sprite = value; }
    public GameObject Prefab { get => _Prefab; set => _Prefab = value; }
}
