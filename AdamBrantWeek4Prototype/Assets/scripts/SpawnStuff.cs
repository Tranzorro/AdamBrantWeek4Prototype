using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnStuff : MonoBehaviour {
    public GameObject GameOverText;
    public float odelay = 0.1f;
    public float pdelay = 2.5f;
    public GameObject obsticle;
    public GameObject pickUp;

	// Use this for initialization
	void Start () {
        InvokeRepeating("OSpawn", odelay, odelay);
        InvokeRepeating("PSpawn", pdelay, pdelay);
	}

    // Update is called once per frame
    private void Update()
    {
        if(lifeCounter.lifeValue <= 0)
        {
            GameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OSpawn()
    {
        Instantiate(obsticle, new Vector3(Random.Range(-8.5f, 8.5f), 10, 0), Quaternion.identity);
    }

    private void PSpawn()
    {
        Instantiate(pickUp, new Vector3(Random.Range(-8.5f, 8.5f), 10, 0), Quaternion.identity);
    }
}