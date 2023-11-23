using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inv : MonoBehaviour
{
    public Transform slotpanel;
    public GameObject uipanel;  
    private bool openinventory = false;
    public List<inventoryslot> slots = new List<inventoryslot>();
    public Camera mainCammera;
    public float RichDistance = 3;
 

    void Start()
    {
      
        mainCammera = Camera.main;
        uipanel.SetActive(false);
        for (int i = 0; i < slotpanel.childCount; i++)
        {
            if (slotpanel.GetChild(i).GetComponent<inventoryslot>() != null)
            {
                slots.Add(slotpanel.GetChild(i).GetComponent<inventoryslot>());
            }
        }        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            openinventory = !openinventory;
            if (openinventory == true)
            {
                uipanel.SetActive(true);
            }
            else
            {
                uipanel.SetActive(false);
            }
        }

        Ray ray = mainCammera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit, RichDistance) )
        {
            Debug.DrawRay(ray.origin, ray.direction* 10, Color.red);
            if (hit.collider.gameObject.GetComponent<Podbor>() != null )
            {
                AddItem(hit.collider.gameObject.GetComponent<Podbor>().itemScripte , hit.collider.gameObject.GetComponent<Podbor>().amount );
                Destroy(hit.collider.gameObject);
            }
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction* 10, Color.green);
        }
    }

    private void AddItem( ItemScript itemm , int amount )
    {
        foreach (inventoryslot slot in slots)
        {
            if (slot.item == itemm)
            {
                slot.ammmount += amount;
                slot.itemAmmountGraf.text = amount.ToString();
                return;

            }
        }
        foreach (inventoryslot slot in slots)
        {
            if (slot.isEmpty == false)
            {
                slot.item = itemm;
                slot.ammmount = amount;
                slot.isEmpty = false;
                slot.SetIcon(itemm.iconka);
                slot.itemAmmountGraf.text = amount.ToString();
                break;
            }
        }
    } 





}
