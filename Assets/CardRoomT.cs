using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardRoomT : MonoBehaviour
{
    bool Firstentry = true;
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
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 2 && Firstentry ==true)
        {
            PlayerMission.text = "What is this place? Why is this not outside? I don't REMEMBER I have this room in my house...";
        }
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 5)
        {
            PlayerMission.text = "Why am in this room again? I feel like I'm going in circle.";
        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 2 && Firstentry == true)
        {
            PlayerMission.text = "What is this place? Why is this not outside? I don't REMEMBER I have this room in my house...";
        }
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 5)
        {
            PlayerMission.text = "Why am in this room again? I feel like I'm going in circle.";
        }

    }
    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player") && GetProgress.GetComponent<Progress>().progressPoint == 2 && Firstentry == true)
        {
            PlayerMission.text = "I need to leave this place.";
        }
        Firstentry = false;

    }
}