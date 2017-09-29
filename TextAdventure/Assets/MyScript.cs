using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{

    public Text myTextbox;

    public enum States{beachStart, beachLater, jungle, cave, nap, jungleDeep, swimForIt, raftForIt, rock, wood, rope, wilsonTake, wilsonKick};
    public States myState;

    public bool wood = false;
    public bool rock = false;
    public bool rope = false;
    public bool wilson = false;
    public bool wilsonReact = false;

    public bool beenJungle = false;
    public bool beenCave = false;
    public bool beenJungleDeep = false;
    public bool beenBeachLater = false;


    // Use this for initialization
    void Start ()
    {
        myState = States.beachStart;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (myState == States.beachStart) { State_beachStart(); }
        if (myState == States.beachLater) { State_beachLater(); }
        if (myState == States.jungle) { State_jungle(); }
        if (myState == States.cave) { State_cave(); }
        if (myState == States.nap) { State_nap(); }
        if (myState == States.jungleDeep) { State_jungleDeep(); }
        if (myState == States.swimForIt) { State_swimForIt(); }
        if (myState == States.raftForIt) { State_raftForIt(); }
        if (myState == States.rock) { State_rock(); }
        if (myState == States.wood) { State_wood(); }
        if (myState == States.rope) { State_rope(); }
        if (myState == States.wilsonTake) { State_wilsonTake(); }
        if (myState == States.wilsonKick) { State_wilsonKick(); }
    }

    void State_beachStart()
    {
         myTextbox.text = "You wake with a start. You're sprawled facedown in warm sand, cool water lapping around your aching body. With some effort, you rise, and find yourself on an island. You're alone." +
            "\nBehind you lies the ocean. You can see debris and Wreckage of your downed plane scattered across the water. In front of you there is a dense Jungle thick with trees and green foliage." +
            "\n\nPress J to go to the Jungle.\nPress W to swim toward the Wreckage.";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.jungle;
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.swimForIt;
        }
    }

    void State_beachLater()
    {
        if (beenBeachLater == false)
        {
            myTextbox.text = "Upon returning to the beach, you find that more debri has washed up on shore. Among the scraps you spot a soccerball." +
            "\n\nPress K to Kick the soccerball in frustration.\nPress T to Take the soccerball.";

            if (Input.GetKeyDown(KeyCode.K))
            {
                beenBeachLater = true;
                myState = States.wilsonKick;
            }

            else if (Input.GetKeyDown(KeyCode.T))
            {
                beenBeachLater = true;
                myState = States.wilsonTake;
            }
        }

        else
        {
            if (wood == true && rope == true && rock == true)
            {
                myTextbox.text = "You're back on the beach." +
                "\n\nPress J to go to the Jungle.\nPress W to swim toward the wreckage.\nPress R to create a Raft.";

                if (Input.GetKeyDown(KeyCode.J))
                {
                    beenBeachLater = true;
                    myState = States.jungle;
                }

                else if (Input.GetKeyDown(KeyCode.W))
                {
                    beenBeachLater = true;
                    myState = States.swimForIt;
                }

                else if (Input.GetKeyDown(KeyCode.R))
                {
                    beenBeachLater = true;
                    myState = States.raftForIt;
                }
            }

            else
            {
                myTextbox.text = "You're back on the beach." +
                "\n\nPress J to go to the Jungle.\nPress W to swim toward the wreckage.";

                if (Input.GetKeyDown(KeyCode.J))
                {
                    beenBeachLater = true;
                    myState = States.jungle;
                }

                else if (Input.GetKeyDown(KeyCode.W))
                {
                    beenBeachLater = true;
                    myState = States.swimForIt;
                }
            }
        }
    }

    void State_jungle()
    {
        if (beenJungle == false)
        {
            myTextbox.text = "Thick, rubbery leaves squeak under your feet as you push your way into the jungle. The trees are smaller near the edge of the jungle, but grow in size the farther you go. You spot a small cave partially hidden behind the greenery." +
            "\n\nPress W to gather some Wood.\nPress C to explore the Cave.\nPress B to go back to the Beach.\nPress D to explore Deeper into the jungle.";
        }

        else
        {
            if (wood == true)
            {
                myTextbox.text = "You are back at the jungle's edge." +
                "\n\nPress C to explore the Cave.\nPress B to go back to the Beach.\nPress D to explore Deeper into the jungle.";
            }

            else
            {
                myTextbox.text = "You are back at the jungle's edge." +
                "\n\nPress W to gather some wood.\nPress C to explore the Cave.\nPress B to go back to the Beach.\nPress D to explore Deeper into the jungle.";
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            beenJungle = true;
            myState = States.wood;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            beenJungle = true;
            myState = States.cave;
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            beenJungle = true;
            myState = States.beachLater;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            beenJungle = true;
            myState = States.jungleDeep;
        }
    }

    void State_cave()
    {
        if (beenCave == false)
        {
            myTextbox.text = "The cave is about 12 feet in diameter and not quite tall enough for you to stand up straight. It's warm and seems safe, and you think about taking a Nap. In the cave, you find a sharp Rock that could be useful." +
            "\n\nPress R to take the sharp Rock.\nPress N to take a Nap.\nPress J to return to return to the Jungle.";
        }

        else
        {
            if (rock == false)
            {
                myTextbox.text = "You're back in the cave." +
                "\n\nPress R to take the sharp Rock.\nPress N to take a Nap.\nPress J to return to return to the Jungle.";
            }

            else
            {
                myTextbox.text = "You're back in the cave." +
                "\n\nPress\nN to take a Nap.\nPress J to return to return to the Jungle.";
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            beenCave = true;
            myState = States.rock;
        }

        else if (Input.GetKeyDown(KeyCode.J))
        {
            beenCave = true;
            myState = States.jungle;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            beenCave = true;
            myState = States.nap;
        }
    }

    void State_nap()
    {
        myTextbox.text = "You nestle yourself into a corner of the cave. The ground is hard, but you're so tired you don't notice. You're asleep within minutes." +
            "\nYou wake up to find a tiger with its jaws clamped around your throat. You aren't awake for long after that." +
            "\n\nYOU DIE";
    }

    void State_jungleDeep()
    {
        if (rope == false)
        {
            myTextbox.text = "You press forward into the jungle. The trees become bigger and closer together the farther you travel. You can't go on much farther. You notice thick Vines hanging from the trees." +
            "\n\nPress V to gather some vines.\nPress J to return to the jungle's edge.";
        }

        else
        {
            myTextbox.text = "You press forward into the jungle. The trees become bigger and closer together the farther you travel. You can't go on much farther." +
            "\n\nPress J to return to the jungle's edge.";
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            beenJungleDeep = true;
            myState = States.jungle;
        }

        else if (Input.GetKeyDown(KeyCode.V))
        {
            beenJungleDeep = true;
            myState = States.rope;
        }
    }


    void State_swimForIt()
    {
        myTextbox.text = "You begin swimming out toward the remains of the plane. Could there be other survivors? Progress is slow as the waves, growing in size, are pushing you back toward the shore. You're about halfway to the wreckage when a massive wave crashes into you. It forces you underwater and you smash into the ocean floor. You're knocked unconscious." +
            "\n\n YOU DIE";
    }

    void State_raftForIt()
    {
        if (wilson == true)
        {
            myTextbox.text = "Using the supplies you've gathered, you fashion a small makeshift raft. You set out onto the open water. Hours pass, then days. The sun is hot, and slowly drains you of your will to live. The only thing that keeps you going is the company of William. At long last, a passing ship spots you floating on the waves. \n\nYOU ARE SAVED";
        }
        
        else
        {
            myTextbox.text = "Using the supplies you've gathered, you fashion a small makeshift raft. You set out onto the open water. Hours pass, then days. The sun is hot, and slowly drains you of your will to live. If only you had a companion to keep you company. Eventually, the isolation and heat drive you to insanity.\n\nYou DIE";
        }
    }

    void State_rock()
    {
        rock = true;

        myTextbox.text = "You pocket the sharp rock." +
        "\n\nPress N to take a Nap.\nPress J to return to return to the Jungle.";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.jungle;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.nap;
        }
    }

    void State_wood()
    {
        wood = true;

        myTextbox.text = "You spend some time gathering fallen wood of varying sizes." +
            "\n\nPress C to explore the Cave.\nPress B to go back to the Beach.\nPress E to Explore farther into the jungle.";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.cave;
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.beachLater;
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.jungleDeep;
        }
    }

    void State_rope()
    {
        rope = true;
        
        myTextbox.text = "With some effort, you yank some of the vines down from above you. They're strong and can't be torn by hand." +
        "\n\nPress J to return to the jungle's edge.";

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.jungle;
        }
    }

    void State_wilsonTake()
    {
        wilson = true;
        wilsonReact = true;

        if (wood == true && rope == true && rock == true)
        {
            myTextbox.text = "You feel strangely affectionate toward the little soccerball. You name it William and take it with you. It makes you feel less alone." +
            "\n\nPress J to go to the Jungle.\nPress W to swim toward the wreckage.\nPress R to make a Raft";

            if (Input.GetKeyDown(KeyCode.J))
            {
                myState = States.jungle;
            }

            else if (Input.GetKeyDown(KeyCode.W))
            {
                myState = States.swimForIt;
            }

            else if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.raftForIt;
            }
        }

        else
        {
            myTextbox.text = "You feel strangely affectionate toward the little soccerball. You name it William and take it with you. It makes you feel less alone." +
           "\n\nPress J to go to the Jungle.\nPress W to swim toward the wreckage.";
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.jungle;
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.swimForIt;
        }
    }

    void State_wilsonKick()
    {
        wilsonReact = true;

        if (wood == true && rope == true && rock == true)
        {
            myTextbox.text = "The stress of your text-based adventuring has you feeling less and less optimistic about your survival. In a fit of frustration and hopelessness, you kick the soccerball as hard as you can and it soars far into the jungle, never to be seen again." +
            "\n\nPress J to go to the Jungle.\nPress W to swim toward the wreckage.\nPress R to build a Raft.";
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            myState = States.jungle;
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.swimForIt;
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.raftForIt;
        }
    }
}
