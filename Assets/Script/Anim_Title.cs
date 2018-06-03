using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Title : MonoBehaviour, IAnimationObject {

	public float maxAlpha = 0.0f;
	private TextMesh textMesh;
	private bool isAppear = false;

	public void AnimInit() {
		textMesh = GetComponent<TextMesh>();
		textMesh.color = new Color(1f,1f,1f, 0.0f);

		// 5秒後に出現
		Invoke("Appear", 5f);
	}

	public void AnimUpdate() {
		if(isAppear) {
			if(textMesh.color.a < maxAlpha) {
				textMesh.color = new Color(1f,1f,1f, textMesh.color.a+(maxAlpha/100));
			}
		}
	}

	void Appear() {
		isAppear = true;
	}
}
