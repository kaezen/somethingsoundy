using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoving : MonoBehaviour {
    public float speed = 5;
    // Update is called once per frame
    void Update () {                
        transform.position += transform.forward * speed * Time.deltaTime;
        
    }
}
