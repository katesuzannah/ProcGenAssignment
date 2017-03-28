using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour {

	public static Vector3 average = Vector3.zero;

	void Start () {
		//Reset values
		average = Vector3.zero;
		transform.position = Vector3.zero;
		Builder.takenPos.Clear ();
	}

	void Update () {
		//Calculate average position of points
			foreach (Vector3 position in Builder.takenPos) {
				average += position;
			}
		if (Builder.takenPos.Count > 0) {
			average = average / Builder.takenPos.Count;
			//Move camera to appropriate position
			transform.position = average + new Vector3 (0f, 50f, 0f);
		}
	}
}
