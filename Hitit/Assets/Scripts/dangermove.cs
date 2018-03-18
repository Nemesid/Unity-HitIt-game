using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangermove : MonoBehaviour {

	public Rigidbody rb;
	public float forwardforce = 500f;
	public float sideforce = 800f;
	void OnCollisionEnter(Collision Collisioninfo)
	{
		if (Collisioninfo.collider.tag == "MoveUp") {
			rb.AddForce (0, forwardforce * Time.deltaTime, 0,ForceMode.VelocityChange);
		}
		if (Collisioninfo.collider.tag == "MoveDown") {
			rb.AddForce (0, -forwardforce * Time.deltaTime, 0,ForceMode.VelocityChange);
		}
		if (Collisioninfo.collider.tag == "Move Right") {
			rb.AddForce (-sideforce * Time.deltaTime,0,  0,ForceMode.VelocityChange);
		}
		if (Collisioninfo.collider.tag == "Move Left") {
			rb.AddForce (sideforce * Time.deltaTime,0,  0,ForceMode.VelocityChange);
		}
	}
}
