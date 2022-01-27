using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalScript : MonoBehaviour
{
    public TMP_Text txt2;
    float fvalue;

    public static FinalScript instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {

        txt2.text = "Score : " + PlayerPrefs.GetFloat("FinalS",0f).ToString();
        
    }
    //public void ScoreBoard()
    //{
    //    Scorer sd = FindObjectOfType<Scorer>();
    //  //  fvalue = sd.finalscore;
    //    txt2.text = "Score : " + sd.finalscore.ToString();
    //    Debug.Log(fvalue);

    //}
    // Update is called once per frame
    void Update()
    {
       // Scorer sd = FindObjectOfType<Scorer>();

       
    }
}
