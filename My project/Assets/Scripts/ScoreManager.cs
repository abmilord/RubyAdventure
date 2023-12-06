using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public text FixedRobots;

    int score= 0;

    // Start is called before the first frame update
    void Start()
    {
        FixedRobots.text = score.ToString() + "POINTS"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
