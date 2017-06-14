using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemProperties : MonoBehaviour {
	// This class is used to be recognised by different game managers

	//Item ID

	//item triggers to distinguish what kind of action to do when it is activated. i.e. open inventory canvas

	//message text when walked over the object

	//Message canvas which will appear when player walks over it
	public GameObject msgCanvas;


	// Use this for initialization
	void Start () {
		msgCanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerStay2D (Collider2D col) {
		if (col.tag == "Player") {
			//do something with the notification manager
			// GameController.ctrl
			msgCanvas.SetActive(true);
		}
	}

	public void OnTriggerExit2D (Collider2D col) {
		if (col.tag == "Player") {
			if (msgCanvas.active) {
				msgCanvas.SetActive (false);
			}
		}
	}
}
