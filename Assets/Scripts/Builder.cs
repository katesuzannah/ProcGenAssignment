using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour {
	
	public Transform jewel1Prefab;
	public Transform jewel2Prefab;
	public Transform jewel3Prefab;
	public Transform jewel4Prefab;
	public Builder BuilderPrefab;
	public static List <Vector3> takenPos = new List<Vector3>();

	void Update () {
		if (BuildingManager.totalBuildings < BuildingManager.buildingMax) {
			
			float newMakerChoice = Random.Range (0f, 100f);
			float buildingChoice = Random.Range (0f, 100f);
			float turnChoice = Random.Range (0f, 100f);

			if (newMakerChoice > 99f) {
				Instantiate (BuilderPrefab, transform.position, Quaternion.identity);
			}

			//Determine if it turns and which way
			if (turnChoice < 10f) {
				transform.Rotate (0f, 90f, 0f);
			}
			else if (turnChoice < 20f) {
				transform.Rotate (0f, 180f, 0f);
			}
			else if (turnChoice < 30f) {
				transform.Rotate (0f, -90f, 0f);
			}

			//Choose which prefab to instantiate
			//if (!takenPos.Contains (transform.position)) {
				if (buildingChoice < 25f) {
					takenPos.Add (transform.position);
					Instantiate (jewel1Prefab, transform.position, Quaternion.identity);
				}
				else if (buildingChoice < 50f) {
					takenPos.Add (transform.position);
					Instantiate (jewel2Prefab, transform.position, Quaternion.identity);
				}
				else if (buildingChoice < 75) {
					takenPos.Add (transform.position);
					Instantiate (jewel3Prefab, transform.position, Quaternion.identity);
				}
				else {
					takenPos.Add (transform.position);
					Instantiate (jewel4Prefab, transform.position, Quaternion.identity);
				}
				BuildingManager.totalBuildings++;
			//}
				
			//Move forward depending on where it's facing
			transform.Translate (Vector3.forward, Space.Self);

		}
		else {
			Destroy (gameObject);
		}
	}
}
