using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{   
    //3 different item groups
    public GameObject itemGroup1;
    public GameObject itemGroup2;
    public GameObject itemGroup3;
    
    //check passes
    private bool door1;
    private bool door2;
    private bool door3;
    private bool door4;

    //items will change based on loop
    private int loop;

    // Start is called before the first frame update
    void Start()
    {   
        //no pass at beginning
        door1 = false;
        door2 = false;
        door3 = false;
        door4 = false;

        loop = 0;

        Debug.Log("Current loop is " + loop);
    }

    // Update is called once per frame
    void Update()
    {   
        // if(loop < 4)
        // {
            //if pass all doors, loop changes
            checkLoop();

            //items will change based on loop number & set door to false
            updateScene();
        // }
    }

    void OnTriggerEnter(Collider other)
    {   
        //odd numbers to true, even number to false

        // door1
        if(other.gameObject.name == "Cube_1")
        {
            if(door1 == false)
            {
                door1 = true;
                Debug.Log("Door 1 passed");
            }else{
                door1 = false;
            }
        }
        
        //door2
        if(other.gameObject.name == "Cube_2")
        {
            if(door2 == false)
            {
                door2 = true;
                Debug.Log("Door 2 passed");
            }else{
                door2 = false;
            }
        }

        //door3
        if(other.gameObject.name == "Cube_3")
        {
            if(door3 == false)
            {
                door3 = true;
                Debug.Log("Door 3 passed");
            }else{
                door3 = false;
            }
        }
        
        //door4
        if(other.gameObject.name == "Cube_4")
        {
            if(door4 == false)
            {
                door4 = true;
                Debug.Log("Door 4 passed");
            }else{
                door4 = false;
            }
        }
        
    }

    void checkLoop()
    {   
        
        if(door1 == true && door2 == true && door3 == true && door4 == true)    //not perfect if statements
        {

            loop++;

            Debug.Log("Current loop is " + loop);
            
            door1 = false;
            door2 = false;
            door3 = false;
            door4 = false;

        }
    }    

    void updateScene()
    {
        if(loop == 1)
        {
            itemGroup1.SetActive(true);
            itemGroup2.SetActive(false);
            itemGroup3.SetActive(false);
        }

        if(loop == 2)
        {
            itemGroup1.SetActive(false);
            itemGroup2.SetActive(true);
            itemGroup3.SetActive(false);
        }

        if(loop == 3)
        {
            itemGroup1.SetActive(false);
            itemGroup2.SetActive(false);
            itemGroup3.SetActive(true);
        }

    }
}
