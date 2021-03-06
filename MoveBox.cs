using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {


    Rigidbody2D rb;
    bool movingRight = true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


        if (transform.position.x > 7)
            movingRight = false;
        if (transform.position.x < -7)
            movingRight = true;
	}



    void FixedUpdate()
    {

        if (movingRight)
            moveRight();
        else
            moveLeft();
    }



    void moveRight()
    {

        rb.velocity = new Vector2(5, 0);
    
    }



    void moveLeft()
    {

        rb.velocity = new Vector2(-5, 0);

    }

}
