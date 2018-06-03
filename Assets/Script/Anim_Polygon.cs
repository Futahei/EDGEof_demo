using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Polygon : MonoBehaviour, IAnimationObject {
	public float speed = 0; // 速度
	public float maxAlpha = 0.7f; // α上限
	public Vector3 angles = Vector3.zero; // 回転角
	public Vector3 direction = Vector3.zero; // 進行方向 兼 スポーン位置
	public float areaRadius = 5.0f;  // 範囲の球の半径

	private Renderer[] renderers;

	public void AnimInit() {
		// ランダム値設定
		speed = Random.value/10.0f;
		maxAlpha = Random.Range(0.0f, 0.7f);
		angles = Random.onUnitSphere * 3f;
		var p = Random.onUnitSphere;
		p.y = p.y>0.0f ? p.y : Random.value; // yが0以下なら再割り当て
		direction = p;

		// マテリアルをキャッチ
		renderers = GetComponentsInChildren<Renderer>();
		foreach(Renderer ren in renderers) {
			ren.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
		}

		// (リ)スポーン
		transform.position = direction;
	}

	public void AnimUpdate() {
		// 回転と位置の変化
		transform.Rotate(angles);
		transform.position += direction * speed;

		// 範囲内か確認
		if(IsInArea(transform.position, transform.parent.position)) {
			AnimInit();
		}

		// 上限値まで増やしていく
		foreach(Renderer ren in renderers) {
			if(ren.material.color.a < maxAlpha)
				ren.material.color = new Color(1.0f, 1.0f, 1.0f, ren.material.color.a+(maxAlpha/100.0f));
		}
	}

	private bool IsInArea(Vector3 position, Vector3 origin) {
		return (position - origin).magnitude > 5.0f;
	}

	void Start () {
		AnimInit();
	}
	
	void Update () {
		AnimUpdate();
	}
}
