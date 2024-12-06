using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Timeline;

public class Logic : MonoBehaviour
{
    public GameObject gamescreen;
    public int score;
    public Text scoreText;
    public AudioSource ding;
    public AudioSource lose;
    public void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        ding = audioSources[0];
        lose = audioSources[1];
    }
    
    [ContextMenu("Increase Score")]
    public void addscore()
    {
        score++;
        scoreText.text = score.ToString();
        ding.Play();
        if (score >= 5)
        {
            scoreText.color = Color.yellow;
        }
        else if(score >= 10)
        {
            scoreText.color = Color.green;
        }
        else if(score >= 20)
        {
            scoreText.color = Color.red;
        }
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void losesound()
    {
        ding.clip=lose.clip;
        ding.Play();
    }
    public void gameover()
    {
        losesound();
    scoreText.text = score.ToString();
        gamescreen.SetActive(true);
        
    }
}
