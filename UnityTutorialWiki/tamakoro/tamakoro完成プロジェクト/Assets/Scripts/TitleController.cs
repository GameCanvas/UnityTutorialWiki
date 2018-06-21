using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {
	
	void Start(){
		
	}
	public void OnStartButtonClicked(){
		SceneManager.LoadScene ("Menu");
	}
}
