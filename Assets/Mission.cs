using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    public Text thistext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        thistext.text = "My Name is Elin. Today, I need to meet my husband Tom and pick up our daughter from the school together.";
    }

    IEnumerator ExampleCoroutine()
    {

        thistext.text = "My Name is Elin. Today, I need to meet my husband Tom and pick up our daughter from the school together.";
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        thistext.text = "";

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
