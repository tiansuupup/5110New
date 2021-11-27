using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Update : MonoBehaviour
{   
    //get doors collider
    public 

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

        loop = 1;
    }

    // Update is called once per frame
    void Update()
    {   
        //check each door
        
        //if pass all doors, loop changes
        checkLoop();

        //items will change based on loop number & set door to false
        updateScene();
    }

    void OnTriggerEnter(Collider collider)
    {
        if(other.CompareTag("Player")
        {
            door1 = true;
        }
    }

    void checkLoop()
    {   

        if(door1 == true && door2 == true && door3 == true && door4 == true)    //not perfect if statements
        {
            loop++;

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
            
        }

        if(loop == 2)
        {

        }

        if(loop == 3)
        {

        }

    }
}
