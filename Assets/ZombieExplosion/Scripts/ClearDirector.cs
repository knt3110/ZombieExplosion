using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour {

	public float time;
	public float span;

	void Start () {

	}

	void Update () {
		this.time += Time.deltaTime;
		if(this.time > this.span){
			SceneManager.LoadScene("TitleScene");
		}
	}
}
