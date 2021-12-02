using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showitems : MonoBehaviour
{
    public GameObject itemGroup1;
    public GameObject itemGroup2;
    public GameObject itemGroup3;

    public GameObject[] tableitems;
    private int i = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ShowMore()
    {
        tableitems[i].SetActive(true);
        i++;
        if (i == 2)
        {
            itemGroup2.SetActive(true);
        }

        if (i == 4)
        {
            itemGroup3.SetActive(true);
        }
    }
}
