using UnityEngine;
using System.Collections;

public class ButtonSound : MonoBehaviour {

	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		DontDestroyOnLoad (this);
	}
	
	public void OnClickButton(){
		audio.Play ();
	}
}
