using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinning : MonoBehaviour {

    float h = 0;
    public float rotateSpeed = 1;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
            h = Input.GetAxis("Horizontal");
        
        //print(h);

        h *= .9f;
        if (h < .3f && h > -.3f) h = 0;

        this.transform.Rotate(0, h*rotateSpeed, 0);
	}
}
