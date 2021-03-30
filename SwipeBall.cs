using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeBall : MonoBehaviour {

    Vector2 starPos, endPos, direction;
    float touchTimestart, touchTimeFinish, timeterval;
    Rigidbody2D rb;
    bool throwAllowed = true;

    [Range(0.05f, 1f)]
    public float throwForse = 0.3f;



	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            touchTimestart = Time.time;
            starPos = Input.GetTouch(0).position;
        
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && throwAllowed)
        {

            touchTimeFinish = Time.time;
            timeterval = touchTimeFinish - touchTimestart;
            endPos = Input.GetTouch(0).position;
            direction = starPos - endPos;


            rb.isKinematic = false;
            rb.AddForce(-direction / timeterval * throwForse);
            throwAllowed = false;
        
        
        }
		
	}
}
