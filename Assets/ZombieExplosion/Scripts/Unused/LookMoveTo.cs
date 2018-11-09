using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour {

	public GameObject ground;

	void Start () {

	}

	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray;
		RaycastHit[] hits;
		GameObject hitObject;

		ray = new Ray(camera.position, camera.rotation*Vector3.forward);
		hits = Physics.RaycastAll(ray);

		for(int i = 0; i < hits.Length; i++){
			RaycastHit hit = hits[i];
			hitObject = hit.collider.gameObject;
			if(hitObject == ground){
				transform.position = hit.point;
			}
		}
	}
}
