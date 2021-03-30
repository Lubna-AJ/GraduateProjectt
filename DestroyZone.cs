using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("Ball"))
        {
            GameControll.instance.DecreaseNumberOfBalls();
            Destroy(col.gameObject);
        
        }

        if (col.gameObject.tag.Equals("puriCan"))
            Destroy(col.gameObject);
    
    }



}
