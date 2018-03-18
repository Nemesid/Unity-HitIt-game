using UnityEngine;

public class BallCollision : MonoBehaviour {
	public Movement move;
	public AndroidMovement And;
	public Rigidbody rb;
	public float boost = 2000f;
	public float hump = 2000f;
	public float ForwardThrust = 5000f;
	public AudioClip boostclip;
	public float Gravity = 200f;
	static public int deathcount =1;
	void Start ()
	{
		
	}

	void OnCollisionEnter(Collision Collisioninfo)
	{

		if (Collisioninfo.collider.tag == "DangerBox") 
		{
			if (deathcount == 5) {
				checkpoint.ischecked = false;
			}
			if ( checkpoint.ischecked == false) {
				move.enabled = false;
				And.enabled = false;
				Handheld.Vibrate ();
				FindObjectOfType<GameManager> ().EndGame ();
				
			}
				
			if (checkpoint.ischecked == true) {
				move.enabled = false;
				And.enabled = false;
				Invoke ("Respawn", 1.5f);
				deathcount = deathcount + 1;
				FindObjectOfType<Life> ().LifePoint ();
				} 


		}

		if (Collisioninfo.collider.tag == "RotationPlane") 
		{
			rb.AddForce (0, 0, boost * Time.deltaTime, ForceMode.VelocityChange);

		}

		if (Collisioninfo.collider.tag == "CylBase") 
		{

			rb.AddForce (0, hump * Time.deltaTime, 0,ForceMode.VelocityChange);


		}
		if (Collisioninfo.collider.tag == "ForwardThrow") 
		{

			rb.AddForce (0, 0, ForwardThrust * Time.deltaTime,ForceMode.VelocityChange);

		}
		if (Collisioninfo.collider.tag == "BrokenBase") 
		{

			rb.useGravity = true;

		}


	}
	public void Respawn()
	{
		transform.position = checkpoint.ReachedPoint;

		move.enabled = true;
		And.enabled = true;
	}


}
