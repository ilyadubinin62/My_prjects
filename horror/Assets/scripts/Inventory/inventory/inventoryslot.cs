using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class inventoryslot : MonoBehaviour
{
    public ItemScript item;
    public int ammmount;
    public bool isEmpty = true;
    public GameObject iconGraf;
    public TMP_Text itemAmmountGraf;

    private void Start()
    {
        iconGraf = transform.GetChild(0).gameObject;
        itemAmmountGraf = transform.GetChild(1).GetComponent<TMP_Text>();
    }
    public void SetIcon(Sprite icon)
    {
        iconGraf.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        iconGraf.GetComponent<Image>().sprite = icon;
    }

}
