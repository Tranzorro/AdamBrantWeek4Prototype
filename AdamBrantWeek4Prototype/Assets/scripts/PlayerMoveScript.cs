using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(Input.GetAxis("Horizontal"),0, 0);

    }

    private void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
