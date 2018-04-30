using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour {
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            lifeCounter.lifeValue -= 1;
            Destroy(gameObject);
        }
        if (lifeCounter.lifeValue <= 0 && col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            
        }
    }
}
