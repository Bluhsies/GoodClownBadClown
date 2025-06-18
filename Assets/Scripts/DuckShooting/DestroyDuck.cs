using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDuck : MonoBehaviour
{

    public AK.Wwise.Event mySound;

    public Collider stressCollider;
   

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.CompareTag("Ball"))
        {

            mySound.Post(gameObject);

            gameObject.SetActive(false);

            stressCollider.enabled = false;

        }

    }


}
