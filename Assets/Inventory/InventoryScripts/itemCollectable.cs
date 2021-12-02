using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollectable : MonoBehaviour
{
    public Item thisItem;
    public Text playerText;
    public Inventory playerInventory;
    private bool canPickup = false;


    void Update()
    {
        if (canPickup == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerText.text = "";
                AddNewItem();
                Destroy(gameObject);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerText.text = "Press E to collect";
            canPickup = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerText.text = "";
            canPickup = false;
        }
    }


    public void AddNewItem()
    {
        playerInventory.itemList.Add(thisItem);
        InventoryManager.CreateNewItem(thisItem);
    }
}
