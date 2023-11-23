using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeItem 
{ 
Bints,
Idrinaline,
Medkit,
Ammo,
Weapon,
Default
}

public class ItemScript : ScriptableObject
{
    public TypeItem itemType;
    public GameObject itemPrefab;
    public Sprite iconka;
    public string itemName;
    public int maximumitem;
    public string info;
}
