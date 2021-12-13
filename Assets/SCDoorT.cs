using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCDoorT : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 1)
        {
            PlayerMission.text = "I REMEMBER that Tom loves Cigarrette. I'd Better bring the lighter for him before leaving";
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