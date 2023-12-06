using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManger : MonoBehaviour
{
<<<<<<< Updated upstream
    public static ScoreManger instane;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if(instane == null)
        {
            instance = this; 
        }
    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }

    
}
=======
public static ScoreManger instance;
public TextMeshProUGUI text;
int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

     void ChangesScore(int coinValue)
    {

    score += coinValue;
    text.text = "X"+score.ToString();

    }
    

}
>>>>>>> Stashed changes
