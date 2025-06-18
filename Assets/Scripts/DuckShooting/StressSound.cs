using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressSound : MonoBehaviour
{

    

    public GameObject duckModel;

    public AK.Wwise.Event myDuckStop;

    public AK.Wwise.Event myStressedDuck;

    private void OnTriggerEnter(Collider other)
    {

        

        if (other.CompareTag("Ball"))
        {

            myDuckStop.Post(duckModel);

            Debug.Log("Trigger works");

            myStressedDuck.Post(duckModel);

        }

    }


}
