using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {
	
	public Rigidbody rb;
	public float forwardforce = 500f;
	void OnCollisionEnter(Collision Collisioninfo)
	{
		if (Collisioninfo.collider.tag == "MoveStart") {
			rb.AddForce (0, 0, forwardforce * Time.deltaTime,ForceMode.VelocityChange);
		}
		if (Collisioninfo.collider.tag == "MoveEnd") {
			rb.AddForce (0, 0, -forwardforce * Time.deltaTime,ForceMode.VelocityChange);
		}
	}
}
