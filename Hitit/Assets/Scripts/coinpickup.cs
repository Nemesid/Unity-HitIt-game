using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour {
	public Transform CoinEffect;
	public int CoinValue = 1;
	
	void OnTriggerEnter (Collider Collisioninfo) 
	{
		if (Collisioninfo.GetComponent<Collider>().tag == "Ball") 
		{
			GameManager.CoinScore += CoinValue;
			var effect = Instantiate (CoinEffect, transform.position, transform.rotation);
			Destroy (effect.gameObject, 3);
			Destroy (gameObject);
		}
		
		
	}
}
