using UnityEngine;
using System.Collections;

public class DestroyDelay : MonoBehaviour {

	private float delay = 5.0f;
	
	// Update is called once per frame
	void Awake () {
		Destroy (gameObject, delay);
	}

}
