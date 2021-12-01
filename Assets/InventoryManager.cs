using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;
    public Inventory playerBag;
    public GameObject myBag;
   
    public Slot slotPrefab;
    bool bagOpened = false;
    // Start is called before the first frame update



    void Awake()
    {
        
        if (instance != null)
        {
            Destroy(this);

        }
        instance = this;
        
    }


    void Start()
    {
        playerBag.itemList.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(bagOpened == true)
            {
                myBag.SetActive(false);
                bagOpened = false;
            }
            else
            {
                myBag.SetActive(true);
                bagOpened = true;
            }
        }
    }

    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(instance.slotPrefab, instance.myBag.transform.position,Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.myBag.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
    }
}
