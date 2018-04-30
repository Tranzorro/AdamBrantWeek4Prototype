using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        //check collision name
        Debug.Log("collision name = " + col.gameObject.name);
        if (col.gameObject.name == "Player")
        {
            lifeCounter.lifeValue += 1;
            Destroy(gameObject);
        
        }
    }
}
