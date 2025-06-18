using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TorchAudio : MonoBehaviour
{

    public AK.Wwise.Event myFlame;

   
    

    // Start is called before the first frame update
    void Start()
    {


        myFlame.Post(gameObject);



    }


    


}
