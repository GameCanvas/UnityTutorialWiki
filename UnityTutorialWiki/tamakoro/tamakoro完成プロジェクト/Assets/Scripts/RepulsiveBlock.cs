using UnityEngine;
using System.Collections;

public class RepulsiveBlock : MonoBehaviour {

	public float repulsiveForce;
	AudioSource boundSound;

	void Start(){
		boundSound = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision other){
		Rigidbody rb = other.gameObject.GetComponent<Rigidbody> ();


		Vector3 direction = transform.position - other.gameObject.transform.position;
		direction.Normalize ();

		if (other.collider.tag == "Player") {
			rb.AddForce (-direction * repulsiveForce);
			boundSound.Play ();
		}
	}

}
