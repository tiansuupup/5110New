using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollectable : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }

    public void AddNewItem()
    {
        playerInventory.itemList.Add(thisItem);
        InventoryManager.CreateNewItem(thisItem);
    }
}
