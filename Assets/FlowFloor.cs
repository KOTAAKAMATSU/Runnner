using UnityEngine;
using System.Collections.Generic;

public class FlowFloor : MonoBehaviour {
	
	public Vector3 speed    = Vector3.zero; //1フレームで動く距離(マイナスは逆方向)
	public Vector3 distance = Vector3.zero; //この距離まで動く
	
	//distanceまで動いた後に反対方向へ折り返して動くか？
	//falseだとdistanceまで動いたらそこで止る
	public bool turn = true;
	
	private Vector3 moved = Vector3.zero; //移動した距離を保持

	
	void Update() {
		//床を動かす
		float x = speed.x;
		float y = speed.y;
		float z = speed.z;

		transform.Translate(x, y, z);
		//動いた距離を保存
		moved.x += Mathf.Abs(speed.x);
		moved.y += Mathf.Abs(speed.y);
		moved.z += Mathf.Abs(speed.z);

		//折り返すか？
		if (moved.x >= distance.x && moved.y >= distance.y && moved.z >= distance.z && turn) {
			speed *= -1; //逆方向へ動かす
			moved = Vector3.zero;
		}
	}
}
