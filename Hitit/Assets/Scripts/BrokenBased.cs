using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBased : MonoBehaviour {
	public Rigidbody rbx;
	public float grav = 200f;

	void OnCollisionEnter(Collision Collisioninfo)
	{
		if (Collisioninfo.collider.tag == "Ball") {
			rbx.AddForce (0, -grav * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
	}
}