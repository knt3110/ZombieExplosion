using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour {

	public void ToGameScene() {
		SceneManager.LoadScene("GameScene");
	}
}
