using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{

     float finalscore = 0 ;
    public TMP_Text txt1;


    public static Scorer instance;

    private void Awake()
    {
        if(instance == null )
        {
            instance = this;
        }
    }

    public void IncrementScore(float value)
    {
       finalscore = finalscore + value;
       print(finalscore);
    }
    void Update()
    {
       PlayerPrefs.SetFloat("FinalS", finalscore);
      txt1.text = "Score : " + finalscore.ToString();
    }
}
