using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour, IAnimationObject {
	public Anim_Polygons animPoly;
	public Anim_Titles animTit;
	bool isAnim = false;

	public void AnimInit() {
		isAnim = true;
		animPoly.AnimInit();
		animTit.AnimInit();
	}

	public void AnimUpdate() {
		animPoly.AnimUpdate();
		animTit.AnimUpdate();
	}

	void Start (){
		AnimInit();
	}

	void Update (){
		if(isAnim)
			AnimUpdate();
	}
}
