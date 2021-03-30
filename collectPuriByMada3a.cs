using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
public class collectPuriByMada3a : MonoBehaviour {


    Rigidbody2D rb;
    float dirX, moveSpeed = 5f;
    float jumpForce = 600f;

    [SerializeField]
    Text PuriCounter;

    [SerializeField]
    GameObject PuriMagnatic;

    int PuriNumber;
    
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

       // dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        PuriCounter.text = PuriNumber.ToString();
        PuriMagnatic.transform.position = new Vector2(transform.position.x, transform.position.y);

        //if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        //{

        //    rb.AddForce(Vector2.up * 700f);
        
        //}


        dirX = CrossPlatformInputManager.GetAxis("Horizontal");

        if (CrossPlatformInputManager.GetButtonUp("Jump"))
            DoJump();

		
	}

    void FixedUpdate()
    {
       // rb.velocity = new Vector2(dirX, rb.velocity.y);
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }




    public void DoJump()
    {

        if (rb.velocity.y == 0)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("puri"))
        {
            Destroy(col.gameObject);
            PuriNumber += 1;
        }

    }

}
