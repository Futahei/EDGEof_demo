using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	void Start () {
		
	}
	void Update () {
		var touchPosition = TouchUtil.GetTouchPosition();
		if(touchPosition!=Vector3.zero) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(touchPosition);
			if(Physics.Raycast(ray, out hit)) {
				hit.transform.GetComponent<Renderer>().material.color = Color.red;
			}
		}
	}
}
