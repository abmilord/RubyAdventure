using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public RubyController Ruby;
    public SpriteRenderer Rubysprite;
    public Button Restart;
    public GameObject WinText;
    public GameObject LoseText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Ruby.isDead)
        {
            gameOver();
            LoseText.SetActive(true);
            Rubysprite.color = Color.red;
        }
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Ruby.enabled = false;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
