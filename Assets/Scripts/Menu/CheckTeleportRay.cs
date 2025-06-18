using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckTeleportRay : MonoBehaviour
{

    public GameObject leftTeleporter;

    public InputActionProperty leftActivate;

    public InputActionProperty leftCancel;

    // Update is called once per frame
    void Update()
    {

        leftTeleporter.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);

    }
}
