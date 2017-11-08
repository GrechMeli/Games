using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text myText;

	// Use this for initialization
	void Start () {
        myText.text = "You are in a prison cell, and you want to" +
            " escape. \nThere are some dirty sheets on the bed, a " +
            "mirror on the wall, and the door is locked from outside.\n\n" +
            "Press S to view the sheets, M to view the mirror and L to view" +
            "the lock.";
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.S))
        {
            myText.text = "Sheets";
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myText.text = "Mirror";
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myText.text = "Lock";
        }

    }
}
