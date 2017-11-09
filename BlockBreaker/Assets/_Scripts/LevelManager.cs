using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static int brickCount;

    void Start()
    {
        brickCount = FindObjectsOfType<Health>().Length;
        
    }

    public void LoadLevel (string name)
    {
        SceneManager.LoadScene(name);
    }

	public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void CheckBrickCount()
    {
        brickCount = FindObjectsOfType<Health>().Length;
        if (brickCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
