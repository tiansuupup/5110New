using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsT : MonoBehaviour
{
    public Text PlayerText;
    public Text MissionText;
    public bool enteredNews = false;
    public bool readNews = false;
    public GameObject GetProgress;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enteredNews == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                MissionText.text = "Yesterday was the 10th Death Anniversary of the famous engineer Tom Rebmemer, his family......";
                PlayerText.text = "";
                readNews = true;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 6)
        {
            PlayerText.text = "Press E to read the Newspaper";
            enteredNews = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && readNews == false)
        {

            PlayerText.text = "";
        }

        if (other.gameObject.CompareTag("Player") && readNews == true)
        {
            enteredNews = false;
            MissionText.text = "What? Tom is dead? How...";
            PlayerText.text = "";
        }
    }
}