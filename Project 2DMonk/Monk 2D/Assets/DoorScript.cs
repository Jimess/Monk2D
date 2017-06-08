using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {
	bool isOpen = false;

	public float angle;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerStay2D (Collider2D col) {
		if (col.transform.tag == "Player") {
			
			if (Input.GetKeyUp (KeyCode.E) && !isOpen) {
				OpenDoors ();
				print ("Working");
				isOpen = true;
			}
		}
	}

	//function that opens doors
	private void OpenDoors () {
		iTween.RotateBy (gameObject, iTween.Hash ("y", angle/360, "oncomplete", "DeactivateDoors"));
	}

	private void DeactivateDoors () {
		foreach (BoxCollider2D col in GetComponents<BoxCollider2D> ()) {
			col.enabled = false;
		}
	}
}
