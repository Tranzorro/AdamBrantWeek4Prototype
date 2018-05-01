using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
    public float speed = 30f;
    Rigidbody2D rigidbody2d;

    void Start () {
    }

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update () {
       // transform.position += new Vector3(Input.GetAxis("Horizontal"),0, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            rigidbody2d.velocity = new Vector2(speed * -1, 0f);
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            rigidbody2d.velocity = new Vector2(speed * 0, 0f);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rigidbody2d.velocity = new Vector2(speed, 0f);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            rigidbody2d.velocity = new Vector2(speed * 0, 0f);
    }

}
