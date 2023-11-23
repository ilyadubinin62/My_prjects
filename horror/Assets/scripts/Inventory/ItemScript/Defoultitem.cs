using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Defoult", menuName = " Inventory /items/Weapon item")]
public class Defoultitem : ItemScript
{
    public bool open;
    void Start()
    {
        itemType = TypeItem.Default;
    }



}
