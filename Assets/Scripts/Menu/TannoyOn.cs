using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TannoyOn : MonoBehaviour
{

    public GameObject[] speaker;
    public GameObject initialSpeaker;

    [Header("Wwise Events")]
    public AK.Wwise.Event myTannoy;
    public AK.Wwise.Event myGreeting;
    public AK.Wwise.Event mySelector;
    public AK.Wwise.Event stopTannoy;
    public AK.Wwise.Event stopGreeting;
    public AK.Wwise.Event stopSelector;

    public float time;

    public float countdown;

    int randomTannoy;

    public bool stopAudio = false;

    void Start()
    {

        time = 0;

        

        StartCoroutine(Tannoy());
        
    }

    
    void Update()
    {

        time += Time.deltaTime;

        Selector();

        if (stopAudio == true)
        {

            
            stopTannoy.Post(initialSpeaker);
            stopGreeting.Post(initialSpeaker);
            stopSelector.Post(speaker[randomTannoy]);

            time = 0;

        }

    }


    IEnumerator Tannoy()
    {

       

        yield return new WaitForSeconds(2.0f);

        myTannoy.Post(initialSpeaker);


       
        yield return new WaitForSeconds(3.0f);

        myGreeting.Post(initialSpeaker);

    }

    public void Selector()
    {

        randomTannoy = Random.Range(0, speaker.Length);

        if (time > countdown)
        {

            mySelector.Post(speaker[randomTannoy]);

            time = 0;

        }

    }

}
