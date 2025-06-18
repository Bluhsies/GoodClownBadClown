using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.CompareTag("Duck") || collision.collider.CompareTag("Balloon"))
        {

            gameObject.SetActive(false);

        }

    }

}
