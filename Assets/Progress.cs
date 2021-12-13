using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public GameObject[] OldNew;
    public GameObject Newspaper;
    public GameObject[] Doors;
    public GameObject tableProgress;
    public int progressPoint;
    // Start is called before the first frame update
    void Start()
    {
        Doors[0].GetComponent<Door>().enabled = false;
        Doors[1].GetComponent<Door>().enabled = false;
        Doors[2].GetComponent<Door>().enabled = false;
        Doors[3].GetComponent<Door>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        progressPoint = tableProgress.GetComponent<showitems>().i;
        switch (progressPoint)
        {
            case 0:
                Doors[3].GetComponent<Door>().enabled = false;
                Doors[0].GetComponent<Door>().enabled = false;
                break;
            case 1:

                Doors[0].GetComponent<Door>().enabled = true;
                Doors[1].GetComponent<Door>().enabled = false;
                break;
            case 2:
                Doors[0].GetComponent<Door>().enabled = false;
                Doors[1].GetComponent<Door>().enabled = true;
                Doors[2].GetComponent<Door>().enabled = true;
                break;
            case 3:
                Doors[0].GetComponent<Door>().enabled = false;
                Doors[2].GetComponent<Door>().enabled = false;
                Doors[3].GetComponent<Door>().enabled = true;
                break;

            case 4:
                Doors[0].GetComponent<Door>().enabled = true;
                Doors[1].GetComponent<Door>().enabled = true;
                Doors[2].GetComponent<Door>().enabled = true;
                Doors[3].GetComponent<Door>().enabled = false;
                break;
            case 5:
                Doors[1].GetComponent<Door>().enabled = true;
                Doors[3].GetComponent<Door>().enabled = false;
                Doors[2].GetComponent<Door>().enabled = true;
                Doors[0].GetComponent<Door>().enabled = false;
                
                break;
            case 6:
                Doors[0].GetComponent<Door>().enabled = true;
                Doors[1].GetComponent<Door>().enabled = true;
                Doors[2].GetComponent<Door>().enabled = false;
                Doors[3].GetComponent<Door>().enabled = true;
                Newspaper.SetActive(true);
                OldNew[0].SetActive(false);
                OldNew[1].SetActive(true);
                break;

        }

    }
}
