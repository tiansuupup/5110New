using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public GameObject[] Doors;
    public GameObject tableProgress;
    public int progressPoint;
    // Start is called before the first frame update
    void Start()
    {
        progressPoint = tableProgress.GetComponent<showitems>().i;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
