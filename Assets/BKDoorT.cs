using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BKDoorT : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 3)
        {
            PlayerMission.text = "Of course, I need to REMEMBER to put on my wedding ring";
        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 3)
        {
            PlayerMission.text = "Of course, I need to REMEMBER to put on my wedding ring";
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