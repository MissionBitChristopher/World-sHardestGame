using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetAxisRaw ("Vertical") > 0 || Input.GetAxisRaw ("Vertical") < 0) &&
			(Input.GetAxisRaw ("Horizontal") > 0 || Input.GetAxisRaw ("Horizontal") < 0)) {
			transform.Translate(new Vector2 (Input.GetAxisRaw ("Horizontal") * Time.deltaTime * speed / Mathf.Sqrt(2), 
				Input.GetAxisRaw ("Vertical") * Time.deltaTime *speed / Mathf.Sqrt(2)));
		} // If the player presses vertical and horizontal movement keys (W,A,S,D or arrow keys), they move diaglonally.

		if (Input.GetAxisRaw ("Vertical") == 0) {

			if (Input.GetAxisRaw ("Horizontal") > 0.5 || Input.GetAxisRaw ("Horizontal") < 0.5) {

				transform.Translate(new Vector2 (Input.GetAxisRaw ("Horizontal") * Time.deltaTime *speed, 0f));
			}
		} // Player can move horizontally.


		if (Input.GetAxisRaw ("Horizontal") == 0) {

			if (Input.GetAxis ("Vertical") > 0.5 || Input.GetAxis ("Vertical") < 0.5) {

				transform.Translate (new Vector2 (0f, Input.GetAxisRaw ("Vertical") * Time.deltaTime* speed));
			}
		} // Player can move veritcally.
	}
}
