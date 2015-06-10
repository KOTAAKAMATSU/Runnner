using UnityEngine;
using System.Collections;

public class Emitter4 : MonoBehaviour
{
	// Waveプレハブを格納する
	public GameObject[] waves;
	
	// 現在のWave
	private int currentWave;
	
	private float x = 10f;
	private float y = 1.86f;//床の高さ調整のための変数
	private float z = -6f;
	
	private float yPlus = 1.25f;
	private float zPlus = 6.05f;
	
	
	IEnumerator Start ()
	{
		
		yield return new WaitForSeconds(3f);
		
		// Waveが存在しなければコルーチンを終了する
		if (waves.Length == 0) {
			yield break;
		}
		
		while (true) {
			
			// Waveを作成する
			GameObject wave = (GameObject)Instantiate (waves [currentWave], new Vector3 (x, y, z), Quaternion.identity);
			
			/// WaveをEmitterの子要素にする
			wave.transform.parent = transform;
			
			// Waveの子要素のCubeが全て削除されるまで待機する
			while (wave.transform.childCount != 0) {
				yield return new WaitForEndOfFrame ();
			}
			
			// Waveの削除
			Destroy (wave);
			
			// 格納されているWaveを全て実行したらcurrentWaveを0にする（最初から -> ループ）
			if (waves.Length <= ++currentWave) {
				currentWave = 0;
				
				
				y += yPlus ;
				z -= zPlus ;
			}
			
		}
	}
	
}