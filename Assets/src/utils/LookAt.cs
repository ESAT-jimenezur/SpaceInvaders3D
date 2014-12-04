using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	private GameObject objectToLook;
	private Vector3 targetPoint;
	private Quaternion targetRotation;

	void Awake(){
		objectToLook = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		targetPoint = new Vector3(objectToLook.transform.position.x, transform.position.y, objectToLook.transform.position.z) - transform.position;
		targetRotation = Quaternion.LookRotation (-targetPoint, Vector3.up);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
	}
}
