using UnityEngine;
using System.Collections;

public class BlotControl : MonoBehaviour {

	public float speed;

	void Start () {
		Rigidbody r = (Rigidbody)GetComponent (typeof(Rigidbody));

		r.velocity = transform.forward * speed;
	}

}
