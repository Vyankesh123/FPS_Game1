using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{

    public TMP_Text txt;
    float time = 0;
    public string SceneName = "ScoreBoard_screen";
    // Start is called before the first frame update
    void Start()
    {
        //txt = GetComponent<TMP_Text>();
        Invoke("changeScene", 10.0f);   
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        print("time = " + time);
        txt.text = "time : " + time.ToString("0.00");
       

    }

    void changeScene()
    {
        SceneManager.LoadScene(2);
    }
}
