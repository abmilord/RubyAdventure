using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class timeManager : MonoBehaviour
{
    public float timer;
    public float timeToRestart;
    public Text timerText;
    public RubyController Ruby;
    public GameManagerScript gameManager;
    public Toggle TimerToggle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timeToRestart)
        {
            Ruby.isDead = true;
            TimerToggle.isOn = false;
            gameManager.gameOver();
        }
        timer += Time.deltaTime;
        // for decimal timer
        timerText.text = timer.ToString("F1");
        // for whole number timer
        // timerText.text = Mathf.Floor(timer).ToString();
    }
    

}
