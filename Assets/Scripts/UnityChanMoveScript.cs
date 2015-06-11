using UnityEngine;
using System.Collections.Generic;

public class UnityChanMoveScript : MonoBehaviour {
	
	public Vector3 speed    = Vector3.zero; //1フレームで動く距離(-が進行方向）
	public Vector3 distance = Vector3.zero; //この距離まで動く


	float axisValue = 0; //-1〜+1の値
	public float value = 10.0f; //移動スピード
	
	
	private Vector3 moved = Vector3.zero; //移動した距離を保持

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	
	void Update() {
		/*/Unityちゃんを動かす
		float x = speed.x;
		float y = speed.y;
		float z = speed.z;
		
		transform.Translate(x, y, z);
		//動いた距離を保存 
		moved.x += Mathf.Abs(speed.x);
		moved.y += Mathf.Abs(speed.y);
		moved.z += Mathf.Abs(speed.z);*/
		Vector3 m_pos = transform.localPosition;
		m_pos.z -= 0.05f;
		transform.localPosition = m_pos;  // 移動を更新

		transform.Translate(new Vector3( 0, 0, axisValue * value * Time.deltaTime ));


		if (Input.GetKey ("space")) {
			animator.SetBool("onJump", true);
		} else {
			animator.SetBool("onJump", false);
		}


		if (Input.GetKey ("up")) {

			axisValue += Time.deltaTime * 0.2f;
			if (axisValue <= 0 ) {
				axisValue += Time.deltaTime;
			}
			
			if (axisValue >= 1.0f) {
				axisValue = 1.0f;
			}


			//transform.position += transform.forward * 0.1f; //加速実装（後々、三角関数を使って緩やかにする）
			animator.SetBool ("is_running", true);
			//m_pos.z -= 0.1f;
			//GetComponent<Rigidbody>().AddForce(Vector3.right * 1.5f);
			//Rigidbody.AddForce(Vector3.up);
			//animator.SetBool("running", true);
			//} else {
			//animator.SetBool("is_running", false);
		}else{
			if (axisValue > 0) {
				axisValue -= Time.deltaTime;
				if (axisValue <= 0) {
					axisValue = 0;
				}
			} else if (axisValue < 0) {
				axisValue += Time.deltaTime;
				if (axisValue >= 0) {
					axisValue = 0;
				}
			}
				animator.SetBool ("is_running", false);
		}
		if (Input.GetKey("right")) {
			//m_pos.x += 0.1f;
			transform.position += transform.right * 0.05f;//右に移動
			//this.transform.position = Vector3(0.1f, 0, 0);
		}
		if (Input.GetKey ("left")) {
			//transform.Rotate(-0.1f, 0, 0);
			transform.position += transform.right * -0.05f;//左に移動
		}



		
	}

}
