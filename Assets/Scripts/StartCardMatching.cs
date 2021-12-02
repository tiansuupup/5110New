using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartCardMatching : MonoBehaviour
{

    public Text playerText;
    public bool enteredArea = false;
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

        if (other.gameObject.CompareTag("Player"))
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
