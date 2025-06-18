using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

    public string sceneName;

    public bool buttonPress;

    public float time;

    public void Start()
    {

        time = 0f;

        buttonPress = false;

    }

    public void sceneSelect()
    {


        buttonPress = true;


    }


    public void Update()
    {

        if (buttonPress == true)
        {

            time += Time.deltaTime;

            if (time > 1)
            {

                StartCoroutine(WaitBeforeLoading());

            }
        }
    }

    public IEnumerator WaitBeforeLoading()
    {

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(sceneName);

        buttonPress = false;

    }

    public void quitGame()
    {

        Application.Quit();

        Debug.Log("Quit game!");

    }


}
