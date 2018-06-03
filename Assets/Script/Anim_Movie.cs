using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Anim_Movie : MonoBehaviour, IAnimationObject {
	private VideoPlayer vPlayer;
	private AudioSource aSource;
	private bool isAppear = false;
	private Material mat;
	public void AnimInit() {
		mat.color = new Color(1,1,1,0);
    Invoke("Appear", 7.0f);
	}

	public void AnimUpdate() {
		if(isAppear) {
			if(mat.color.a<1) {
				mat.color = new Color(1,1,1, mat.color.a+0.01f);
			} else {
				if(!vPlayer.isPlaying) {
					AnimReStart();
				}
			}
		}
	}

	public void AnimReStart() {
		vPlayer.Play();
		aSource.Play();
	}

	public void AnimStop() {
		vPlayer.Pause();
		aSource.Pause();
	}

	void Appear () {
		isAppear = true;
	}

	void Awake (){
		mat = GetComponent<Renderer>().material;
		vPlayer = GetComponent<VideoPlayer>();
		aSource = GetComponent<AudioSource>();
	}
}
