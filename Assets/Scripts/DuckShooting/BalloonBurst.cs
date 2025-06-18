using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBurst : MonoBehaviour
{
    public AK.Wwise.Event mySound;

    


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Ball"))
        {

            mySound.Post(gameObject);

            gameObject.SetActive(false);

            

        }

    }
}
