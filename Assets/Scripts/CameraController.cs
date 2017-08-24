using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame (guranteed to run after all the items have been processed)
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
