
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {
	static public bool ischecked = false;
	static public Vector3 ReachedPoint;
	public AudioClip checktune;
	void OnTriggerEnter(Collider Collisioninfo)
	{
		if (Collisioninfo.GetComponent<Collider> ().tag == "Ball") 
		{
			GetComponent<AudioSource> ().playOnAwake = false;
			GetComponent<AudioSource> ().clip = checktune;
			GetComponent<AudioSource> ().Play ();

				ReachedPoint = transform.position;
				ischecked = true;

		}	
	}
}
