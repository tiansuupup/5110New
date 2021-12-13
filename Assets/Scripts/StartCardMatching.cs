using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartCardMatching : MonoBehaviour
{

    public Text playerText;
    public bool enteredArea = false;
    public int loopnum = 0;
    public GameObject PlayerProgress;

    void Start()
    {
        
    }
    void Update()
    {
        if (enteredArea == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerText.text = "";
                
                SceneManager.LoadScene("_Level_1");
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        Loop curloop = go.GetComponent<Loop>();
        int loopnum = curloop.loop;
        if (other.gameObject.CompareTag("Player") && PlayerProgress.GetComponent<Progress>().progressPoint == 6)
        {
            playerText.text = "Press E to remember";
            enteredArea = true;
           
        }
    }


    void OnTriggerExit(Collider other)
    {
        enteredArea = false;
        if (other.gameObject.CompareTag("Player"))
        {
            playerText.text = "";
        }
    }
}
