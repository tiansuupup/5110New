using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject myBag;
    bool bagOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
