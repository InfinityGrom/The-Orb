using UnityEngine;
using System.Collections;

public class Quicksand : MonoBehaviour {

	public float downwardSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D c) {
		if (c.gameObject.tag == "Player") {
			c.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
				c.gameObject.GetComponent<Rigidbody2D>().velocity.x, -downwardSpeed);		
		}
	}
}
