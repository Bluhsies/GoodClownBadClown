using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{


    public InputActionProperty aActionButton;
    public float buttonThreshold = 0.1f;

    public bool isButtonDown = false;

    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {

        aActionButton.action.Enable();

    }

    // Update is called once per frame
    void Update()
    {


        float buttonValue = aActionButton.action.ReadValue<float>();

        if (buttonValue > buttonThreshold && !isButtonDown)
        {


            isButtonDown = true;

            OnAButtonPress();

        }



    }


    private void OnAButtonPress()
    {

        canvas.SetActive(true);

        Debug.Log("A button pressed!");

    }

}

