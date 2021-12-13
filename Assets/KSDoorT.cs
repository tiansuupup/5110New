using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KSDoorT : MonoBehaviour
{
    public Text PlayerMission;
    public GameObject GetProgress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 0 )
        {
            PlayerMission.text = "I REMEMBER that Tom is taking medicine these day. I need to find the medicine and bring it to Tom";
        }
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 4)
        {
            PlayerMission.text = "Tom need to REMEMBER not to put his boots in the study again...";
        }

    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMission.text = "";
        }
    }
}
