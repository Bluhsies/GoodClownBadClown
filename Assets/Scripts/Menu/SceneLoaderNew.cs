using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AK.Wwise;
using UnityEngine.UI;

public class SceneLoaderNew : MonoBehaviour
{

    public Slider newSlider;

    public GameObject flame;

    public AK.Wwise.Event fireAudio;

    public GameObject loadingScreen;

   

    public void LoadLevel(int sceneIndex)
    {

        StartCoroutine(LoadAsync(sceneIndex));
        


    }

    public IEnumerator LoadAsync(int sceneIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {

            float progress = Mathf.Clamp01(operation.progress / .9f);

            newSlider.value = progress;
            

            yield return null;

        }


    }

    

    public void LevelQuit()
    {

        

        Application.Quit();

        

    }

    public void StopAudio()
    {


        fireAudio.Stop(flame);


    }

}
