using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Adrinaline Item", menuName = " Inventory /items/Boost item")]

public class IdrinalineItem : ItemScript
{
    public float speed;
    public float time;
    void Start()
    {
        itemType = TypeItem.Idrinaline;
    }

    
}
