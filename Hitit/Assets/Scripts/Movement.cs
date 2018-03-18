
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardforce = 4000f;
	public float sideforce = 500f;
	public float speed = 3f;
	public Movement move;
	public AndroidMovement And;
	void FixedUpdate () 
	{

		if (Input.GetKey ("w"))
		{
			rb.AddForce (0, 0, forwardforce * Time.deltaTime);
		}
		if (Input.GetKey ("d"))
		{
			rb.AddForce (sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("a"))
		{
			rb.AddForce (-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -0.3f) 
		{
			if (BallCollision.deathcount == 5) {
				checkpoint.ischecked = false;
			}
			if (checkpoint.ischecked == true) {
				move.enabled = false;
				And.enabled = false;
				FindObjectOfType<BallCollision> ().Respawn ();
				BallCollision.deathcount = BallCollision.deathcount + 1;
				FindObjectOfType<Life> ().LifePoint ();
			}
			if (checkpoint.ischecked == false) {
				move.enabled = false;
				And.enabled = false;
				Handheld.Vibrate ();
				FindObjectOfType<GameManager> ().EndGame ();
			}

		}
	}

}
