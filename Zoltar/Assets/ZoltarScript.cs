using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoltarScript : MonoBehaviour
{
    const int HALF = 2;

    int max = 100;
    int min = 1;
    int guess = 100 / HALF;

	// Use this for initialization
	void Start ()
    {
        print("Please allow me to introduce myself. My name is Zoltar, the mind reader.");
        print("Please, in your mind's eye, pick a number from " + min + " and " + max + ".");

        print("Do tell, is your number higher or lower than " + guess + "?");
        print("(UP arrow for higher, DOWN arrow for lower, or ENTER for equals)");

        max++;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Higher
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / HALF;
            print("Is the number higher or lower than " + guess + "?");
        }

        // Lower
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / HALF;
            print("Is the number higher or lower than " + guess + "?");
        }

        // Got it
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Zoltar has uncovered your number from the mists of clairvoyance...Zoltar has determined your number to be " + guess + "!");
        }
    }
}
