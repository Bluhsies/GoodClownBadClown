using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopAudio : MonoBehaviour
{

    

    [Header("Wwise Events")]
    public AK.Wwise.Event mySound;


    public float time;

    public float countdown;






    public void Update()
    {

        time += Time.deltaTime;

        duckSound();





    }


    private void duckSound()
    {


        if (time > countdown)
        {

            mySound.Post(gameObject);

            time = 0;



        }


    }


}
