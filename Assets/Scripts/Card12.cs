using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card12 : MonoBehaviour
{
    public bool isUp = false;
    public int ID;


    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnBack()
    {
        this.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self); //flip the card
    }

    void OnMouseDown()
    {

        if (isUp == false)
        {
            isUp = true;
            this.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self); //flip the card
            GameObject.Find("CardManager").GetComponent<CardManager>().CardTurningUp();


            if (GameObject.Find("CardManager").GetComponent<CardManager>().CompareID1 == 0)
            {
                GameObject.Find("CardManager").GetComponent<CardManager>().CompareID1 = ID;
                GameObject.Find("CardManager").GetComponent<CardManager>().CardName1 = this.name;
            }

            else

            if (GameObject.Find("CardManager").GetComponent<CardManager>().CompareID2 == 0)
            {
                GameObject.Find("CardManager").GetComponent<CardManager>().CompareID2 = ID;
                GameObject.Find("CardManager").GetComponent<CardManager>().CardName2 = this.name;
            }


        }


    }
}
