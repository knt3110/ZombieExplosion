using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTarget : MonoBehaviour {

	void Start () {
		StartCoroutine(RePositionWithDelay());
	}

	IEnumerator RePositionWithDelay(){
		while(true){
			SetRandomPosition();
			yield return new WaitForSeconds(5);
		}
	}

	void SetRandomPosition(){
		float x = Random.Range(-5.0f, 5.0f);
		float z = Random.Range(-5.0f, 5.0f);
		transform.position = new Vector3(x, 0, z);
	}
}
