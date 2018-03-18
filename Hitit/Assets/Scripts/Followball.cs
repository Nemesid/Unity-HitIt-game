using UnityEngine;

public class Followball : MonoBehaviour {
	public Vector3 offset;

	public Transform Ball;
	// Update is called once per frame
	void Update () {
		transform.position = Ball.position + offset;

	}

}
