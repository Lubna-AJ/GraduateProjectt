using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knives : MonoBehaviour {

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.name.Equals("janbiax"))
            rb.isKinematic = false;

    }


    void OnCollisionEnter2D(Collision2D col)
    {

        StartCoroutine(LoadAfterDelay("winJ1"));
       // Application.LoadLevel("InstaJ2");
    }

    IEnumerator LoadAfterDelay(string levelname)
    {


        yield return new WaitForSeconds(01);
        Application.LoadLevel(levelname);


    }


}
