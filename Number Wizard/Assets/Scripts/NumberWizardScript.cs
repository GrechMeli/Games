using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess = 500;

    // Use this for initialization
    void Start () {

        print("Welcome to the Number Wizard!");
        print("Pick a number between 1 and 1000!");


        print("Is the number higher, lower or equal to " + guess + "?");
        print("UP arrow: higher, DOWN arrow: lower, ENTER: equal");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("up"))
        {
            print("Up Arrow is pressed!");
            min = guess;
            guess = (min + max) / 2;

            print("Is the number higher, lower or equal to " + guess + "?");
            print("UP arrow: higher, DOWN arrow: lower, ENTER: equal");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow is pressed!");
            max = guess;

            guess = (min + max) / 2;

            print("Is the number higher, lower or equal to " + guess + "?");
            print("UP arrow: higher, DOWN arrow: lower, ENTER: equal");
        }

        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("Enter key is pressed!");
            print("I won!");
        }
           

    }
}
