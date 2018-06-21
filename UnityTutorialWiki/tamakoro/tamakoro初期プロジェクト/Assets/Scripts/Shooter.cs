using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject bulletPrefab;
	public float shotSpeed;
	public int shotFrequency;
	int t=0;
	Vector3 addVector=new Vector3(1,0,0);
	Vector3 vector=new Vector3(1,0,0);

	
	// Update is called once per frame
	void Update () {
		if (t % shotFrequency == 0) {
			Shot();
		}
		t++;
	}

	void Shot(){
		
		GameObject bullet = (GameObject)Instantiate (
			                   bulletPrefab, transform.position+addVector, Quaternion.identity);


		Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody> ();

		bulletRigidbody.AddForce (vector * shotSpeed);
	
	}
}
