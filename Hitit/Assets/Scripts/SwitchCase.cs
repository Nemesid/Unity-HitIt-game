using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour {
	public Transform Lift;
	public Transform Ball;
	public Rigidbody rbxx, rbb;
	void start()
	{
		rbxx = Lift.GetComponent<Rigidbody> ();
		rbb = Ball.GetComponent<Rigidbody> ();
	}
	
	void OnCollisionEnter(Collision Collisioninfo)
	{
		if (Collisioninfo.collider.tag == "CorrectSwitch") {
			rbxx.AddForce (0, -90 * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
		if (Collisioninfo.collider.tag == "WrongSwitch") {
			rbb.AddForce (70000 * Time.deltaTime, 70000 * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
	}
}
