using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Item", menuName = " Inventory /items/Weapon item")]


public class WeaponScript : ItemScript
{
    public int maxValue; 
    void Start()
    {
        itemType = TypeItem.Weapon;
    }

}
