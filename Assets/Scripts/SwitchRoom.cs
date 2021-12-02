using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoom : MonoBehaviour
{
    public GameObject Player;
    public Transform[] SpawnPoints; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Player.transform.position = SpawnPoints[0].position;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Player.transform.position = SpawnPoints[1].position;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Player.transform.position = SpawnPoints[2].position;

        }
    }
}
