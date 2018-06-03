using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour, IAnimationObject {
	public Anim_Polygons animPoly;
	public Anim_Titles animTit;
	public Anim_Movie animMov;
	bool isAnim = false;
	bool isFirst = true;

	public void AnimInit() {
		isAnim = true;
		if(isFirst) {
			animPoly.AnimInit();
			animTit.AnimInit();
			animMov.AnimInit();
			isFirst = false;
		} else {
			animMov.AnimReStart();
		}
	}

	public void AnimUpdate() {
		animPoly.AnimUpdate();
		animTit.AnimUpdate();
		animMov.AnimUpdate();
	}

	public void AnimStop() {
		isAnim = false;
		animMov.AnimStop();
	}

	void Update (){
		if(isAnim)
			AnimUpdate();
	}
}
