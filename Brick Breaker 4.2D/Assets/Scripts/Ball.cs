using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public PaddleScript paddle;
    Vector3 paddleBallPosDiff;
    bool gamestarted = false;
	// Use this for initialization
	void Start () {

        paddleBallPosDiff = this.transform.position - paddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        if (!gamestarted)
        {
            this.transform.position = paddle.transform.position + paddleBallPosDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gamestarted)
        {
            gamestarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f,10f);
        }
        

	}
}
