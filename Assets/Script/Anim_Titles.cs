using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Titles : MonoBehaviour, IAnimationObject {

	public List<Anim_Title> titles;
  private bool isMove = false;

	public void AnimInit() {
		foreach(IAnimationObject title in titles) {
			title.AnimInit();
		}
    Invoke("Move", 6.0f);
	}

	public void AnimUpdate() {
		foreach(IAnimationObject title in titles) {
			title.AnimUpdate();
		}
    if(isMove&&transform.localPosition.z>-2.5f) {
      transform.Translate(new Vector3(0,-0.01f,0));
    }
	}

  void Move() {
    isMove = true;
  }

	void Awake () {
		foreach(Transform ch in transform) {
			var an = ch.GetComponent<Anim_Title>();
			if(an!=null)
				titles.Add(an);
		}
	}
}
