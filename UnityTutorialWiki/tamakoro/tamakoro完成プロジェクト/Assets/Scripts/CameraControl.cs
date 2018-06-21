using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public Transform target;
	Vector3 relativePosition;
	void Start () {
		relativePosition = transform.position - target.position;
	}
	void LateUpdate () {
		transform.position = target.position + relativePosition;
	}
}