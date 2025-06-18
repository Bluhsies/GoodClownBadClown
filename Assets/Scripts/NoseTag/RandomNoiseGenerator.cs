using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNoiseGenerator : MonoBehaviour
{

    public GameObject[] clownHeads;
    public NoseTagScorer scorer;

    [Header("Wwise Events")]
    public AK.Wwise.Event[] myRandomNoises;
    public AK.Wwise.Event[] myStopRandomNoises;

    public int randomHead;
    public float timer;
    public float countdown;
    public float switcher;
    public int randomSound;
    public bool isPlaying;
    private bool stopCurrentAudio; //new

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        stopCurrentAudio = false; //new
        timer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {


        if (!isPlaying)
        {

            StartCoroutine(RandomSound());
        }
        
    }

    public void StopCurrentAudio() //new
    { stopCurrentAudio = true;}

    IEnumerator RandomSound()
    {
        isPlaying = true;
   

        for (int i = 0; i < 3; i++)
        {

            if(stopCurrentAudio) //new
            {
                randomHead = Random.Range(0, clownHeads.Length); //moved from above
                stopCurrentAudio = false;
            }

            randomSound = Random.Range(0, myRandomNoises.Length);

            myRandomNoises[randomSound].Post(clownHeads[randomHead]);

            yield return new WaitForSeconds(5);

            if(stopCurrentAudio) //new
            {

                

                myStopRandomNoises[randomSound].Post(clownHeads[randomHead]);

                break;

            }

        }

        yield return new WaitForSeconds(5);

        isPlaying = false;

    }

   

}
