using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillTarget : MonoBehaviour {

	public GameObject target;
	public GameObject killEffect;
	public Text Score;
	public float timeToSelect = 3.0f;
	public int score;
	public int clearScore = 10;
	public AudioClip se;

	private float countDown;
	private float toClearTime = 0;
	private int flag = 0;

	void Start(){
		score = 0;
		countDown = timeToSelect;
	}

	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit) && (hit.collider.gameObject == target)){
			if(countDown > 0.0f){
				countDown -= Time.deltaTime;
			} else{
				Instantiate(killEffect, target.transform.position, target.transform.rotation);
				GetComponent<AudioSource>().PlayOneShot(se);
				score += 1;
				if(score == this.clearScore){
					flag = 1;
				}
				Score.text = score.ToString() + " Point";
				SetRandomPosition();
			}
		}
		else{
			countDown = timeToSelect;
		}

		if (flag == 1) {
			toClearTime += Time.deltaTime;
			if (toClearTime > 0.5f) {
				SceneManager.LoadScene("ClearScene");
			}
		}
	}


	void SetRandomPosition(){
		int flag_x = Random.Range(0, 2);
		int flag_z = Random.Range(0, 2);
		float x = 4.0f;
		float z = 4.0f;

		if (flag_x == 0) {
			x = Random.Range(-5.0f, -3.0f);
		} else {
			x = Random.Range(3.0f, 5.0f);
		}

		if (flag_z == 0) {
			z = Random.Range(-5.0f, -3.0f);
		} else {
			z = Random.Range(3.0f, 5.0f);
		}

		target.transform.position = new Vector3(x, 0.0f, z);
	}
}
