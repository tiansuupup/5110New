using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{

    public Transform[] CardPoints; //Create the positions
    public GameObject[] Cards; //load all the cards

    public bool isComparing = false;


    public int UpCards = 0;
    public int matchedCards = 0;
    public int CompareID1 = 0;
    public int CompareID2 = 0;


    public string CardName1 = "";
    public string CardName2 = "";
    public GameObject mousediable;
    public GameObject Middle;
    public AudioSource audioPlay;
    public AudioClip[] audioClips;

    
    
   
    
    void Start()
    {
        Cards.Shuffle(24);//Randomly shuffle swap 24 cards
        PutCards();

    }

    // Update is called once per frame
    void Update()
    {
        if (UpCards == 2 && isComparing == false)
        {
            mousediable.GetComponent<BoxCollider>().enabled = true;
            StartCoroutine(CompareTwoCards());
        }
    }

    void PutCards()
    {
        for (int i = 0; i < Cards.Length; i++)
        {
            Cards[i].transform.position = CardPoints[i].position;
        }
    }

    public void CardTurningUp()
    {
        audioPlay.PlayOneShot(audioClips[0]);
        UpCards++;
    }
    
    IEnumerator CompareTwoCards()
    {
        AudioSource audioPlay = GetComponent<AudioSource>();
        isComparing = true;
        if (CompareID1 == CompareID2)
        {
            Debug.Log("Yes");

            

            if (CardName1 == "Card1" || CardName2 == "Card1")                   //If the cardname match, play the certain audio. 
            {


                 
                audioPlay.PlayOneShot(audioClips[4]);
                yield return new WaitForSeconds(audioClips[4].length);          //WaitForSeconds of the length of the clip
            }
            if (CardName1 == "Card3" || CardName2 == "Card3")
            {

                audioPlay.PlayOneShot(audioClips[5]);
                yield return new WaitForSeconds(audioClips[5].length);
                audioPlay.PlayOneShot(audioClips[6]);
                yield return new WaitForSeconds(audioClips[6].length);

            }
            if (CardName1 == "Card5" || CardName2 == "Card5")
            {

                audioPlay.PlayOneShot(audioClips[7]);
                yield return new WaitForSeconds(audioClips[7].length);
            }
            if (CardName1 == "Card7" || CardName2 == "Card7")
            {

                audioPlay.PlayOneShot(audioClips[8]);
                yield return new WaitForSeconds(audioClips[8].length);

            }
            if (CardName1 == "Card9" || CardName2 == "Card9")
            {

                audioPlay.PlayOneShot(audioClips[9]);
                yield return new WaitForSeconds(audioClips[9].length);

            }
            if (CardName1 == "Card11" || CardName2 == "Card11")
            {

                audioPlay.PlayOneShot(audioClips[10]);
                yield return new WaitForSeconds(audioClips[10].length);
                audioPlay.PlayOneShot(audioClips[11]);
                yield return new WaitForSeconds(audioClips[11].length);

            }

            mousediable.GetComponent<BoxCollider>().enabled = false;         //restore everything so the players can keep playing 
            isComparing = false;
            CompareID1 = 0;
            CompareID2 = 0;
            CardName1 = "";
            CardName2 = "";
            UpCards = 0;
            
            

            
            
            
            yield break;
        }


        else
        {
            if (CompareID1 != CompareID2)
            {

                audioPlay.PlayOneShot(audioClips[2]);
                Debug.Log("No");
                UpCards = 0;

                yield return new WaitForSeconds(1.5f);
                GameObject.Find(CardName1).transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
                GameObject.Find(CardName2).transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);



                if (GameObject.Find(CardName1).GetComponent<Card1>() != null)       //Now try to flip the first wrong card
                {
                    GameObject.Find(CardName1).GetComponent<Card1>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card2>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card2>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card3>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card3>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card4>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card4>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card5>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card5>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card6>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card6>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card7>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card7>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card8>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card8>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card9>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card9>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card10>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card10>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card11>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card11>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card12>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card12>().isUp = false;
                }


                if (GameObject.Find(CardName2).GetComponent<Card1>() != null)       //Now try to flip the second wrong card
                {
                    GameObject.Find(CardName2).GetComponent<Card1>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card2>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card2>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card3>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card3>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card4>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card4>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card5>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card5>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card6>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card6>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card7>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card7>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card8>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card8>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card9>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card9>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card10>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card10>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card11>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card11>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card12>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card12>().isUp = false;
                }

                CompareID1 = 0;
                CompareID2 = 0;
                CardName1 = "";
                CardName2 = "";
;
                isComparing = false;
                mousediable.GetComponent<BoxCollider>().enabled = false;
                yield break;

            }
               
        }

    }


}
