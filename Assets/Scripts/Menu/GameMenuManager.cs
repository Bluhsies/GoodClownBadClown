using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameMenuManager : MonoBehaviour
{

    public GameObject menu;
    public Transform head;
    public float spawnDistance = 1f;
    public InputActionProperty showButton;
    public float fadeDuration = 1f;
    

    public CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {

        
        showButton.action.Enable();

        Time.timeScale = 1f;

        canvasGroup = menu.GetComponent<CanvasGroup>();

        if(canvasGroup == null )
        {

            canvasGroup = gameObject.AddComponent<CanvasGroup>();

        }

        canvasGroup.alpha = 0;
        menu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {

            if (menu.activeSelf)
            {

                StartCoroutine(FadeOut());
                

            }
            else
            {

                menu.SetActive(!menu.activeSelf);
                
                menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
                menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
                menu.transform.forward *= -1;
                StartCoroutine(FadeIn());
                

            }


        }

        

    }


    private IEnumerator FadeIn()
    {

        float elapsedTime = 0f;
        Time.timeScale = 0f;

        while (elapsedTime < fadeDuration)
        {

            elapsedTime += Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(0,1,elapsedTime / fadeDuration);
            
            yield return null;

        }

        canvasGroup.alpha = 1;
        
    }

    private IEnumerator FadeOut()
    {

        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {

            elapsedTime += Time.unscaledDeltaTime;
            canvasGroup.alpha = Mathf.Lerp(1, 0, elapsedTime / fadeDuration);
            
            yield return null;

        }

        canvasGroup.alpha = 0;
        menu.SetActive(false);
        Time.timeScale = 1f;
        
    }

}
