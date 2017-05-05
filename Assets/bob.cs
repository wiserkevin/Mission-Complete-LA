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
		float hSpeed = Input.GetAxis("Horizontal") * Speed;
		float vSpeed = Input.GetAxis ("Vertical") * Speed;

		// Pushes rb
		rb.AddForce (new Vector3 (hSpeed, 0, vSpeed));
	}
}
