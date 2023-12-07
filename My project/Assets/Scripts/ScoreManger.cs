using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//whole script by Jacob Lermond
public class ScoreManger : MonoBehaviour
{
    public static ScoreManger instance;
    public TextMeshProUGUI text;
    int score;
    public bool coinsDone;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            coinsDone = false;
        }
    }
    void Update()
    {

    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X"+score.ToString();
        if(score >= 3)
        {
            coinsDone = true;
        }
    }


    
}
