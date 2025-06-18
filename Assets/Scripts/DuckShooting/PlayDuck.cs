using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayDuck : MonoBehaviour
{

    [Header("Wwise Events")]
    public AK.Wwise.Event myDuck;
    

    public float time;

    public float countdown;

    


    

    public void Update()
    {

        time += Time.deltaTime;

        duckSound();

        



    }


    private void duckSound()
    {

        
        if(time > countdown)
        {

            myDuck.Post(gameObject);

            time = 0;

            

        }


    }

   

}
