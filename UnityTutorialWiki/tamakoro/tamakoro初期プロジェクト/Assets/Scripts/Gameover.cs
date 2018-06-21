using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {
	public GameObject gameOver;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			gameOver.SetActive (true);
			Invoke ("ReturnMenu", 2.0f);
		}

		if (other.tag == "Bullet") {
			Destroy (other.gameObject);
		}
	
	}

	void ReturnMenu(){
		SceneManager.LoadScene ("Menu");
	}

}
