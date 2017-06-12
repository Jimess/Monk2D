using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour {
	//swtiches needed to activate for the platform to open
	public SwitchController [] switches;
	// the total width of the platform. current one square width is 1.
	public int platformCount = 1;

	// direction
	public int direction = 1;


	// Use this for initialization
	void Start () {
		foreach (SwitchController swt in switches) {
			swt.SetMovingPart (this);
		}
	}
	
	public void OpenPlatform () {
		bool canOpen = true;
		foreach (SwitchController swt in switches) {
			if (!swt.isActive) {
				canOpen = false;
				break;
			}
		}

		//this part starts the animation of mover and deactivates collider when done.
		if (canOpen) {
			if (direction == 1) {
				iTween.MoveBy (gameObject, iTween.Hash ("x", platformCount, "time", 2f, "easetype", iTween.EaseType.linear, "oncomplete", "FinishOpen"));
			} else if (direction == -1) {
				iTween.MoveBy (gameObject, iTween.Hash ("x", -platformCount, "time", 2f, "easetype", iTween.EaseType.linear, "oncomplete", "FinishOpen"));

			}
		}
	}

	public void FinishOpen () {
		foreach (PolygonCollider2D obj in GetComponentsInChildren<PolygonCollider2D> ()) {
			obj.enabled = false;
		}
	}
}
