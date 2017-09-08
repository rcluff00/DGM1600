using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoltarScript : MonoBehaviour
{
    const int HALF = 2;

    int max = 100;
    int min = 1;
    int guess;

    public int counter;

	// Use this for initialization
	void Start ()
    {
        guess = Random.Range(min, max);

        // Intro   
        print("My name is Zoltar, the mind reader.");
        print("Please, in your mind's eye, pick a number from " + min + " and " + max + ".");

        // Instructions
        print("Do tell, is your number higher or lower than " + guess + "?");
        print("(UP arrow for higher, DOWN arrow for lower, or ENTER for equals)");

        max++;
	}

    // Update is called once per frame
    void Update()
    {
        if (counter == -1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.DownArrow)))
            {
                print("The fog of unclarity still shrouds your number. You win!");
            }
        }
        
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            counter--;
            print("Is your number higher or lower than" + guess + "?");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            counter--;
            print("Is your number higher or lower than" + guess + "?");
        }

        if (Input.GetKeyDown (KeyCode.Return))
        {
            print("I have uncovered your number from the mists of clairvoyance. I win!");
        }

        if (counter == 0)
        {
            counter--;
        }
    }
}
