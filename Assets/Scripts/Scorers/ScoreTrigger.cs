using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField]
    private NoseTagScorer noseScore;

    private void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.CompareTag("Nose"))
        {

            noseScore.UpdateScoreValue(1);

        }
    }



}
