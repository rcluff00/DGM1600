using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hiscore : MonoBehaviour {

    public Text hiscoreText;
    public int hiscore;

    // Use this for initialization
    void Start () {
        hiscore = PlayerPrefs.GetInt("hiscore", 0);
        hiscoreText.text = "HISCORE: " + hiscore;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
