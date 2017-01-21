using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    public GameObject bullet;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) Shoot();
	}
    void Shoot()
    {
        GameObject item;
        item = Instantiate(bullet, this.transform.position, transform.rotation);
    }

    
}
