using System.Collections;
using UniRx.Async; //必要
using UnityEngine;

public class Test : MonoBehaviour
{
	async void Start()
	{
		// コルーチン(IEnumerator)をawaitできる
		await MoveCoroutine();
		Debug.Log("Done!");
		await MoveCoroutine2();

		Debug.Log("Done!2");
	}

	//数秒間前に進むコルーチン
	IEnumerator MoveCoroutine()
	{
		var start = Time.time;
		while (Time.time - start < 2)
		{
			transform.position += Vector3.forward * Time.deltaTime;
			yield return null;
		}
	}

	//数秒間右に進むコルーチン
	IEnumerator MoveCoroutine2()
	{
		var start = Time.time;
		while (Time.time - start < 2)
		{
			transform.position += Vector3.right * Time.deltaTime;
			yield return null;
		}
	}

}