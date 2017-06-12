using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {
	public bool isActive = false;

	private PlatformMover movingPart;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetMovingPart (PlatformMover go) {
		movingPart = go;
	}

	public void OnTriggerStay2D (Collider2D col) {
		if (col.transform.tag == "Player" && !isActive && Input.GetKey(KeyCode.E)) {
			print (name + "Activated");
			isActive = true;
			movingPart.OpenPlatform ();
		}
	}
}
