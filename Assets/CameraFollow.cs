using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public Transform myPlayah;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		Vector3 pos = transform.position;
		pos.x = myPlayah.position.x;
		pos.y = myPlayah.position.y + 5;
		pos.z = myPlayah.position.z - 2;
		
		transform.position = pos;
	}
}
