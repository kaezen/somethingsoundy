using UnityEngine;
using System.Collections;

public class PlayahMovement : MonoBehaviour 
{
	public float vspeed = 0;
	public float hspeed = 0;
	private const float ACC = .01f;
	private const float ACC_MAX = .2f;
	public bool hitL = false;
	public bool hitR = false;
	public bool hitU = false;
	public bool hitD = false;
	
	private float disL = 0;
	private float disR = 0;
	private float disU = 0;
	private float disD = 0;
	
	public float fatness = .5f;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		movement();
	}
	
	private void movement()
	{
		collisionDis();
		
		if (Input.GetAxis("Vertical") > 0)
		{
			vspeed = disU;
			if (hitU)
				vspeed = 0;
		}
		else if (Input.GetAxis("Vertical") < 0)
		{
			vspeed = disD;
			if (hitD)
				vspeed = 0;
		}
		else
			vspeed = 0;
		
		if (Input.GetAxis("Horizontal") > 0)
		{
			hspeed = disR;
			if (hitR)
				hspeed = 0;
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			hspeed = disL;
			if (hitL)
				hspeed = 0;
		}
		else
			hspeed = 0;				
		
		Vector3 dir = transform.position;
		dir.x += hspeed;
		dir.z += vspeed;
		transform.position = dir;
	}
	
	private void collisionDis()
	{
		Vector3 here = transform.position;
		RaycastHit hit;
		disL = -ACC_MAX;
		disR = ACC_MAX;
		disU = ACC_MAX;
		disD = -ACC_MAX;
		
		hitL = Physics.Raycast(here,Vector3.left,out hit,Mathf.Abs(-ACC_MAX-fatness));
		if (hitL)
			disL = -hit.distance;
		hitR = Physics.Raycast(here,Vector3.right,out hit,Mathf.Abs(ACC_MAX+fatness));
		if (hitR)
			disR = hit.distance;
		hitU = Physics.Raycast(here,Vector3.forward,out hit,Mathf.Abs(ACC_MAX+fatness));
		if (hitU)
			disU = hit.distance;
		hitD = Physics.Raycast(here,Vector3.back,out hit,Mathf.Abs(-ACC_MAX-fatness));
		if (hitD)
			disD = -hit.distance;
	}
}
