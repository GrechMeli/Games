using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {

    public int maxHits;
    int timesHit;
    public static int breakableCount = 0;
    LevelManager levelManager = new LevelManager();
    AudioClip crack;
    
	// Use this for initialization
	void Start () {
        breakableCount++;
        print(breakableCount);

        crack = Resources.Load("Sounds/crack", typeof(AudioClip)) as AudioClip;

        timesHit = 0;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + ": " + timesHit);

        AudioSource.PlayClipAtPoint(crack, this.transform.position);

        if (timesHit >= maxHits)
        {
            //TestWin();
            breakableCount--;
            print(breakableCount);
            Destroy(gameObject);
        }
    }

    void TestWin()
    {
        levelManager.LoadNextScene();
    }
}
