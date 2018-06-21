using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {
    private AudioSource sound;
    private GameObject bridge;

    private void Awake()
    {
        bridge = GameObject.Find("Bridge");
        //あらかじめ橋をみえないようにしておく。
        bridge.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
