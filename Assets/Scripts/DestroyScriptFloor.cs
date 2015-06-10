using UnityEngine;
using System.Collections;

public class DestroyScriptFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 5); //5秒後にGameObjectを削除
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
