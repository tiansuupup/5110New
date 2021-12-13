using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CBDoorT : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 2)
        {
            PlayerMission.text = "Why am I back in the Bedroom Again? Anyway, I need to REMEMBER to take my daughter's teddy bear.";
        }
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 5)
        {
            PlayerMission.text = "Wait, I REMEMBER my daughter's favorite toy truck is also here.";
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