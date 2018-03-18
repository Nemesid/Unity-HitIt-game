using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMovement : MonoBehaviour {

	private bool moveleft;
	private bool moveright;
	private bool moveforward;
	public Rigidbody rb;
	public float forwardSpeed = 4000f;
	public float sideSpeed = 100f;

	void FixedUpdate () {
		if (moveleft && !moveright) {
			rb.AddForce (-sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (moveright && !moveleft) {
			rb.AddForce (sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (moveforward) {
			rb.AddForce (0, 0, forwardSpeed * Time.deltaTime);
		}
	}

	public void MoveMeLeft()
	{
		moveleft = true;
	}
	public void StopMeLeft()
	{
		moveleft = false;
	}

	public void MoveMeRIght()
	{
		moveright = true;
	}
	public void StopMeRIght()
	{
		moveright = false;
	}
	public void MoveMeForward()
	{
		moveforward = true;
	}
	public void StopMeForward()
	{
		moveforward = false;
	}
}

