using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour {

	public void Click1(){
		SceneManager.LoadScene ("scene1");
	}

	public void Click2(){
		SceneManager.LoadScene ("scene2");
	}

	public void Click3(){
		SceneManager.LoadScene ("scene3");
	}

	public void Click4(){
		SceneManager.LoadScene ("scene4");
	}
	public void Click5(){
		SceneManager.LoadScene ("scene5");
	}
}
