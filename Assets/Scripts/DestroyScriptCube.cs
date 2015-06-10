using UnityEngine;
using System.Collections;

public class DestroyScriptCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Destroy(gameObject, 2.5f); //x秒後にGameObjectを削除
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionExit(Collision collision){
		Destroy (gameObject, 0.5f);
		Debug.Log ("UnityChan Tuuka!!");
		/*if (other.gameObject.tag == "UnityChan") {
			Debug.Log ("UnityChan Tuuka!!");
		}*/
	}
}
