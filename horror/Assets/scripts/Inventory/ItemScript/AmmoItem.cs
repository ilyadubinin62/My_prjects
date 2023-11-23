using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ammo Item", menuName = " Inventory /items/Ammo item")]

public class AmmoItem : ItemScript
{
    public float Damage;
    void Start()
    {
        itemType = TypeItem.Ammo;
    }


}
