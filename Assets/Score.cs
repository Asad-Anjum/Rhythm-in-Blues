using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{

    public static Score2 instance;

    public TMP_Text scoreText;
    public int score = 0;


    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    // Update is called once per frame
    public void AddPoint(){
        score++;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
