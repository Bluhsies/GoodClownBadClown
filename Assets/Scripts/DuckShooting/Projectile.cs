using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Projectile : MonoBehaviour
{

    public InputActionProperty triggerAction;
    public float triggerThreshold = 0.1f; 

    private bool isTriggerPressed = false;

    public ObjectPooler pooler;
    public float projectilePower = 10f;

    public AK.Wwise.Event myPop;
    public GameObject popLocation;
    
    void Start()
    {
       
        triggerAction.action.Enable();
    }

    
    void FixedUpdate()
    {
        float triggerValue = triggerAction.action.ReadValue<float>();

        if (triggerValue > triggerThreshold && !isTriggerPressed)
        {
            pooler.SpawnPrefab();
            isTriggerPressed = true;
            OnTriggerPressed();
            myPop.Post(popLocation);
        }
        else if (triggerValue <= triggerThreshold && isTriggerPressed)
        {
            isTriggerPressed = false;
            OnTriggerReleased();
        }
    }

    private void OnTriggerPressed()
    {

        

        
        //Debug.Log("Trigger pressed!");
        

        FireFood();
    }

    private void OnTriggerReleased()
    {
        
        //Debug.Log("Trigger released!");
        
    }

    public void FireFood()
    {

        Rigidbody projectile = pooler.ballPrefab.GetComponent<Rigidbody>();

        projectile.AddForce(pooler.spawnPosition.TransformDirection(Vector3.forward) * Mathf.Clamp(projectilePower, 10f, 25f), ForceMode.Impulse);

        

    }


}
