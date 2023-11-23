using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Bint Item", menuName = " Inventory /items/ Healing item")]

public class BintItem : ItemScript
{
    public float health; 

     private void Start()
     {
        itemType = TypeItem.Bints;
      }
   
}
