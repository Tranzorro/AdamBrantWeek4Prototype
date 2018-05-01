using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
    public float speed = 3f;
    Rigidbody2D rigidbody2d;

    void Start () {
    }

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rigidbody2d.velocity = new Vector2(speed * -1, 0f);
        if (Input.GetKey(KeyCode.RightArrow))
            rigidbody2d.velocity = new Vector2(speed, 0f);
    }

    // Update is called once per frame
    void Update () {
       // transform.position += new Vector3(Input.GetAxis("Horizontal"),0, 0);

    }

}
