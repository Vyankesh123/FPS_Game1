using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{

     float finalscore = 0 ;
    public TMP_Text txt1;

    public void IncrementScore(float value)
    {
       finalscore = finalscore + value;
       print(finalscore);
    }
    void Update()
    {
      txt1.text = "Score : " + finalscore.ToString();
       //FinalScript fs = FindObjectOfType<FinalScript>();
       // fs.ScoreBoard(finalscore);


    }
}
