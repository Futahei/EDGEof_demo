using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Polygons : MonoBehaviour, IAnimationObject {

	public List<Anim_Polygon> polygons;
	private bool isPlay = true;

	public void AnimInit() {
		foreach(IAnimationObject polygon in polygons) {
			polygon.AnimInit();
		}
	}

	public void AnimUpdate() {
		foreach(IAnimationObject polygon in polygons) {
			polygon.AnimUpdate();
		}
	}

	public void AnimStop() {

	}

	void Awake () {
		foreach(Transform ch in transform) {
			var an = ch.GetComponent<Anim_Polygon>();
			if(an!=null)
				polygons.Add(an);
		}
	}
}
