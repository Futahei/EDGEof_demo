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
					Application.OpenURL("https://geo.itunes.apple.com/jp/album/reason/583843024?i=583843096&app=itunes");
				}
			}
		}
	}
}
