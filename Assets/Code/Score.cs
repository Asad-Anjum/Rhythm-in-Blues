using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;

    public TMP_Text scoreText;
    int score = 0;

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
