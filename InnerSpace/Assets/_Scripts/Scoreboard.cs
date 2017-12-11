using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

    public GameObject meteor;

    public int score;
    public int hiscore;
    public int lives;

    public Text scoreText;
    public Text livesText;
    public Text waveText;
    public Text hiscoreText;


    // Use this for initialization
    void Start () {
        hiscore = PlayerPrefs.GetInt ("hiscore", 0);

        score = 0;

        scoreText.text = "SCORE:" + score;
        hiscoreText.text = "HISCORE: " + hiscore;
        livesText.text = "LIVES: " + lives;

        Instantiate(meteor, new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-6.0f, 6.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
    }
	
    public void IncrementScoreboard(int value)
    {
        score += value;

        if (score > hiscore)
        {
            PlayerPrefs.SetInt("hiscore", score);
        }

    }

	// Update is called once per frame
	void SaveScore() {
        PlayerPrefs.SetInt("HighScore", score);
		
	}

    public int GetScore()
    {
        return PlayerPrefs.GetInt("HighScore");
    }

    public void OnDisable()
    {
        SaveScore();
    }
}
