using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBase : MonoBehaviour {

	public Transform Gate;

	public Rigidbody rbg;
	void start()
	{
		rbg = Gate.GetComponent<Rigidbody> ();

	}

	void OnCollisionEnter(Collision Collisioninfo)
	{
		if (Collisioninfo.collider.tag == "StopBase") {
			rbg.AddForce (0, 100 * Time.deltaTime, 0, ForceMode.VelocityChange);
		
		}
	}
}