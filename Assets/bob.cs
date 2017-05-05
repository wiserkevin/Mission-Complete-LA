using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob : MonoBehaviour {

	public float Speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Gets input
		float hSpeed = Input.GetAxis ("Horizontal") * Speed;
		float vSpeed = Input.GetAxis ("Vertical") * Speed;
		float jSpeed = 0;

		// Only allows jump on floor
		if (rb.position.y <= 0.5) 
			jSpeed = Input.GetAxis ("Jump") * Speed * 100;

		// Pushes rb
		rb.AddForce (new Vector3 (hSpeed, jSpeed, vSpeed));
	}
}
