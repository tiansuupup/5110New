using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
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
