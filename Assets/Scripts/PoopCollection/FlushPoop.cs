using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlushPoop : MonoBehaviour
{

    

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.CompareTag("Toilet"))
        {

            gameObject.SetActive(false);

        }

    }



}
