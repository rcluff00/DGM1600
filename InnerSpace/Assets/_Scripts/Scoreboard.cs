﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

    public GameObject spawnedMeteor;
    public GameObject spawnedPowerup;

    public int spawnRate;
    public int powerupSpawnRate;
    public int score;
    public int hiscore;
    public int lives;

    public Text scoreText;
    public Text livesText;
    public Text hiscoreText;

    public GameObject healthScript;
    

    void Start () {
        hiscore = PlayerPrefs.GetInt ("hiscore", 0);
        lives = healthScript.GetComponent<Health>().health;
        score = 0;

        scoreText.text = "SCORE:" + score;
        hiscoreText.text = "HISCORE: " + hiscore;
        livesText.text = "LIVES: " + lives;

        //Spawn Meteors
        InvokeRepeating("SpawnMeteorLeft", 1.0f, spawnRate);
        InvokeRepeating("SpawnMeteorRight", 4.0f, spawnRate);
        InvokeRepeating("SpawnMeteorBottom", 3.0f, spawnRate);
        InvokeRepeating("SpawnMeteorTop", 2.0f, spawnRate);

        //Spawn Powerups
        InvokeRepeating("SpawnPowerup", 1.0f, powerupSpawnRate);
    }

    // Spawn meteors randomly
    void SpawnMeteorLeft()
    {
        Instantiate(spawnedMeteor, new Vector3(Random.Range(-7.0f, -12.0f), Random.Range(-8.0f, 8.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
    }
    void SpawnMeteorRight()
    {
        Instantiate(spawnedMeteor, new Vector3(Random.Range(7.0f, 12.0f), Random.Range(-8.0f, 8.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
    }
    void SpawnMeteorBottom()
    {
        Instantiate(spawnedMeteor, new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-7.0f, -12.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
    }
    void SpawnMeteorTop()
    {
        Instantiate(spawnedMeteor, new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(7.0f, 12.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
    }

    // Spawn powrups randomly
    void SpawnPowerup()
    {
        Instantiate(spawnedPowerup, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0), Quaternion.identity);
    }

    public void IncrementScoreboard(int pointValue)
    {
        score += pointValue;
        scoreText.text = "SCORE: " + score;

        if (score > hiscore)
        {
            hiscore = score;
            hiscoreText.text = "HISCORE: " + score;
            PlayerPrefs.SetInt("hiscore", score);  
        }
    }

    public void AdjustLives()
    {
        lives = healthScript.GetComponent<Health>().health;
        livesText.text = "LIVES: " + lives;
    }

}
