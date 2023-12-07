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
    public ScoreManger Score;
    public EnemyController Enemy;
    AudioSource audioSource;
    public AudioClip winSound;
    public AudioClip loseSound;
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
            
            PlaySound(loseSound);
        }
        if(Enemy.fixingDone && Score.coinsDone)
        {
            gameOver();
            WinText.SetActive(true);
            Rubysprite.color = Color.green;

            PlaySound(winSound);
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

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
