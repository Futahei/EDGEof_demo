using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if(TouchUtil.GetTouch()==TouchInfo.Began) {
			var touchPosition = TouchUtil.GetTouchPosition();
			if(touchPosition!=Vector3.zero) {
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(touchPosition);
				if(Physics.Raycast(ray, out hit)) {
					// hit.transform.GetComponent<Renderer>().material.color = Color.red;
					Application.OpenURL("https://open.spotify.com/track/5HkOHdVwSVKawkkypYnZaZ?si=PDgpAfkPR0yPoqIG7Eo_XA");
				}
			}
		}
	}
}
