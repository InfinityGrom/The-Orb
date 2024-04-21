using UnityEngine;
using System.Collections;

public class TeleportPoint : MonoBehaviour {

	//set from inspector
	public TeleportPoint otherPoint;
	public bool teleportedTo;
	public bool killVelocity;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player" && !teleportedTo && otherPoint != null) {

			col.GetComponent<Rigidbody2D>().isKinematic = true;
			if (killVelocity)
			{
				col.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				col.GetComponent<Rigidbody2D>().angularVelocity = 0f;
			}
			col.transform.position = otherPoint.transform.position;
			col.GetComponent<Rigidbody2D>().isKinematic = false;
			//col.rigidbody2D.MovePosition(new Vector2(otherPoint.transform.position.x, otherPoint.transform.position.y));
			otherPoint.teleportedTo = true;
			teleportedTo = false;

			if (transform.GetComponent<AudioSource>() != null)
			{
				transform.GetComponent<AudioSource>().Play ();
			}
		}
	}
	
	void OnTriggerStay2D(Collider2D col)
	{
		if (col.tag == "Player") {
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Player") {
			teleportedTo = false;
		}
	}
}
