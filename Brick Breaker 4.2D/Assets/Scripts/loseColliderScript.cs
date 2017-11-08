using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseColliderScript : MonoBehaviour {
    LevelManager levelManager = new LevelManager();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");

        levelManager.LoadNewScene("Lose");
    }
}
