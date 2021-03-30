using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuriCoin : MonoBehaviour {


    Rigidbody2D rb;
    GameObject mada3a;
    Vector2 Mada3aDirection;
    float timestamp;
    bool flyToMada3a;

	// Use this for initialization
	void Start () {


        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


        if (flyToMada3a)
        {
            Mada3aDirection = -(transform.position - mada3a.transform.position).normalized;
            rb.velocity = new Vector2(Mada3aDirection.x, Mada3aDirection.y) * 10f * (Time.time / timestamp);
        
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name.Equals("PuriMagnatic"))
        {
            timestamp = Time.time;
            mada3a = GameObject.Find("mada3a");
            flyToMada3a = true;
        }
    }

}
