using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MedKid Item", menuName = " Inventory /items/ MedKid Item")]
public class MedkidItem : ItemScript
{
    public float health;

    private void Start()
    {
        itemType = TypeItem.Medkit;
    }


}
