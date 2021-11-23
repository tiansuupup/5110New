using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preface : MonoBehaviour {
    GameObject prefaceGO;
    public RawImage rawImg;
    public GameObject mousedis;

    void Awake()
    {
        mousedis.GetComponent<BoxCollider>().enabled = true;

        prefaceGO = GameObject.Find( "Preface" );
        rawImg = prefaceGO.GetComponent<RawImage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( Fade() );
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Fade()
    {
        while ( rawImg.color.a > 0.1f ) {
            rawImg.color = Color.Lerp( rawImg.color, Color.clear, Time.deltaTime * ( 1.001f - rawImg.color.a ) );
            yield return new WaitForSeconds( 0.0004f );
        }
        prefaceGO.SetActive( false );
        mousedis.GetComponent<BoxCollider>().enabled = false;
        Destroy( prefaceGO );
    }
}
