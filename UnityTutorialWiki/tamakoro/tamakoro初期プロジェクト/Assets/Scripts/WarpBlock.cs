using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WarpBlock : MonoBehaviour {


	public GameObject goalText;

	AudioSource audio;

	void Start(){
		audio = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "Player") {
			goalText.SetActive (true);
			other.rigidbody.velocity = Vector3.zero;
			audio.Play ();
			Invoke ("ReturnMenu", 2.0f);
		}
			
	}

	void ReturnMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
