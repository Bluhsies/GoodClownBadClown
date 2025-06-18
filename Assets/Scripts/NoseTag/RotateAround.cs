using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public GameObject rotateTarget;

    

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(rotateTarget.transform.position, Vector3.up, 20 * Time.deltaTime);


    }
}
