using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public float distance = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward,out hit,distance)){
            Vector3 normal = hit.normal;
            if (hit.transform.gameObject.layer == 8)
            {
                hit.transform.gameObject.GetComponent<WallColoring>().Glow();
                TimeToRotate(normal);
            }
        }

    }
    void TimeToRotate(Vector3 normal)
    {
        transform.rotation = Quaternion.FromToRotation(Vector3.forward, Vector3.Reflect(transform.forward, normal));
    }
   
}
