using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSounds : MonoBehaviour
{

    [Header("Wwise Events")]
    public AK.Wwise.Event myPoop;

    public GameObject[] myPoops;

    public float time;

    public float countdown;

    int randomPoop;

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        poopSound();

    }


    private void poopSound()
    {

        randomPoop = Random.Range(0, myPoops.Length);

        if(time > countdown) 
        {

            myPoop.Post(myPoops[randomPoop]);

            time = 0;

        }

        

    }

}
