using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    
    public TMP_Text points;
    public void Setup(int score){
        gameObject.SetActive(true);
        points.text = "SCORE: " + score.ToString();
    }

    public void restartButton(){
        SceneManager.LoadScene("SampleScene");
    }
}
