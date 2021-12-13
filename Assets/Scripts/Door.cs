using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter( Collider other )
    {
        if (!enabled) return;
        anim.SetBool( "opened", true );

    }

    void OnTriggerExit( Collider other )
    {
        if (!enabled) return;
        anim.enabled = true;
        anim.SetBool( "opened", false );
    }

    void PauseAnimation()
    {
        if (!enabled) return;
        anim.enabled = false;
    }
}
