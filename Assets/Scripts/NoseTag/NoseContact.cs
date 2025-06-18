using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoseContact : MonoBehaviour
{

    

    private Collider noseCollider;

    public NoseOn noseOn;

    public float timer;

    public float restartNose;

    public bool timerStart;

    public void Start()
    {


        restartNose = 20;
        
        noseCollider = gameObject.GetComponent<Collider>();
        

        timer = 0f;

        timerStart = false;
        
    }

    public void Update()
    {

        if (timerStart == true)
        {
            timer += Time.deltaTime;

            if(timer > restartNose)
            {

                
                normalNose();

            }

        }

    }

    

    public void OnCollisionExit(Collision collision)
    {
        
        if(collision.collider.CompareTag("Player"))
        {

            timerStart = true;

            noseCollider.enabled = false;

        }

        

        Debug.Log("Two");

    }

    public void normalNose()
    {

        noseCollider.enabled = true;

        timer = 0;

        Debug.Log("Three");

    }

}
