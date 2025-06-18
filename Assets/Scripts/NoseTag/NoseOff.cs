using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoseOff : MonoBehaviour
{

    public AK.Wwise.Event mySound;

    public NoseTagScorer noseTag;

    private Renderer noseRender;

    public RandomNoiseGenerator soundOff;

    public float timer;
    public float countdown;
    public bool turnOn;

    // Start is called before the first frame update
    void Start()
    {
        noseRender = gameObject.GetComponent<Renderer>();

        turnOn = false;
        timer = 0;
        countdown = 0;
    }


    private void Update()
    {

        if (turnOn)
        {

            timer += Time.deltaTime;

            if (timer > countdown && turnOn)
            {

                noseRender.material.SetColor("_Color", Color.red);

                turnOn = false;

                timer = 0;

            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {



        if (collision.collider.CompareTag("Player"))
        {

            mySound.Post(gameObject);

            noseRender.material.SetColor("_Color", Color.black);

            soundOff.StopCurrentAudio();

            

        }

        Debug.Log("One");

    }

    public void OnCollisionExit(Collision collision)
    {
        
        if(collision.collider.CompareTag("Player"))
        {



            turnOn = true;


        }


    }
}
