using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float enemyhitScore;
   

    private void OnCollisionEnter(Collision collision)
    {
       Scorer sc = FindObjectOfType<Scorer>();
        sc.IncrementScore(enemyhitScore);
    }

}
