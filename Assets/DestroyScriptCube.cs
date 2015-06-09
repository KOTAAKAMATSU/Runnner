using UnityEngine;
using System.Collections;

public class DestroyScriptCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 2.8f); //x秒後にGameObjectを削除
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
