using UnityEngine;
using System.Collections;

public class BoundBlock : MonoBehaviour {
	public float boundForce;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	void OnCollisionEnter(Collision other){
		Rigidbody rb = other.gameObject.GetComponent<Rigidbody> ();

		Vector3 direction = new Vector3 (0, 0, 0);
		direction.y = other.gameObject.transform.position.y - transform.position.y;
		direction.Normalize ();

		if (other.collider.tag == "Player") {
			rb.AddForce (direction * boundForce);
			audio.Play ();
		}
	}
}
