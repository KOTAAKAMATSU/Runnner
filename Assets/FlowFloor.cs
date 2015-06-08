using UnityEngine;
using System.Collections.Generic;

public class FlowFloor : MonoBehaviour {
	
	public Vector3 speed    = Vector3.zero; //1フレームで動く距離(マイナスは逆方向)
	public Vector3 distance = Vector3.zero; //この距離まで動く
	

	
	private Vector3 moved = Vector3.zero; //移動した距離を保持

	
	void Update() {
		/*//床を動かす
		float x = speed.x;
		float y = speed.y;
		float z = speed.z;

		transform.Translate(x, y, z);
		//動いた距離を保存
		moved.x += Mathf.Abs(speed.x);
		moved.y += Mathf.Abs(speed.y);
		moved.z += Mathf.Abs(speed.z);*/
		Vector3 m_pos = transform.localPosition;
		m_pos.z += 0.05f;
		transform.localPosition = m_pos;  // 移動を更新


	}
}
