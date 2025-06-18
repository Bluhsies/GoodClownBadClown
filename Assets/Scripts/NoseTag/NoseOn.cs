using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NoseOn : MonoBehaviour
{

    public NoseContact nose;

    private Renderer noseRender;
    // Start is called before the first frame update
    void Start()
    {
        noseRender = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame

   

    public void noseOn()
    {

        

        noseRender.material.SetColor("_Color", Color.red);

        nose.timer = 0f;
        nose.timerStart = false;

        Debug.Log("Three");

    }
}
