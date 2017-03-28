using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingManager : MonoBehaviour {

	public static int totalBuildings;
	public static int buildingMax;
	public Transform builderObj;

	void Start () {
		//Build the first path builder
		Instantiate (builderObj, transform.position, Quaternion.identity);
		totalBuildings = 0;
		//Two buckets for small and large patterns
		if (Random.Range(0, 100) < 50) {
			buildingMax = Random.Range (5, 50);
		}
		else if (Random.Range(0, 100) >= 50) {
			buildingMax = Random.Range (150, 300);
		}
	}

	void Update () {
		//Reload the scene
		if (Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}