using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoseTagScorer : MonoBehaviour
{

    public TMP_Text m_Text;

    [SerializeField]
    private int scoreValue;
    [SerializeField]
    private int winScore;
    public string playerScore;
    public string roundScore;

    private void Start()
    {
        
        scoreValue = 0;

        UpdateScoreText();

    }

    public void UpdateScoreValue(int scoreUpdate)
    {

        scoreValue += scoreUpdate;

        UpdateScoreText();

        if(scoreValue >= winScore)
        {

            Time.timeScale = 0;

        }


    }

    void UpdateScoreText()
    {

        m_Text.text = playerScore + " " + scoreValue + roundScore;

    }

}
