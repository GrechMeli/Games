using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Paddle paddle;
    Vector3 paddleBallPosDiff;
    bool gameStarted = false;

	// Use this for initialization
	void Start () {
        
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleBallPosDiff = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!gameStarted) // if(gameStarted == false)
        {
            this.transform.position = paddle.transform.position + paddleBallPosDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colName = collision.collider.name;
        string colTag = collision.collider.tag;

        //if (gameStarted &&(colName == "Paddle" || colName == "Left Border" || colName == "Right Border" || colName =="Top Border")) // if(gameStarted == true)
        if(gameStarted && (colTag != "Breakable"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
